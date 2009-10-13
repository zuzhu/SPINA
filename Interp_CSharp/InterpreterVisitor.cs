////////////////////////////////////////////////////////////////////////
// InterpreterVisitor.cs: Implements a vistor that interprets the 
//  syntax tree.
// 
// version: 1.2
// description: add new visit-functions
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
// 
// version: 1.1
// description: add "Hashtable mIntVariableMap;" and "Stack<MatrixElement> mStack;"
//   to support the matrix computation
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

public class InterpreterVisitor : Visitor {

  Hashtable mVariableMap;
  Hashtable mIntVariableMap;
  Stack<MatrixElement> mStack;
  Stack<IntegerElement> mIntStack;
  Dictionary<String, Element> mDict;
  Queue<int> mQueue;
  WriteBufferDelegate dele;

  //----< constructor >------------------------------

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mIntVariableMap = new Hashtable();
    mStack = new Stack<MatrixElement>();
    mIntStack = new Stack<IntegerElement>();
    mDict = new Dictionary<string, Element>();
    mQueue = new Queue<int>();
  }

  //----< set a delegate >------------------------------

  public void setDelegate(WriteBufferDelegate value) { dele = value; }

  //----< visit Variable >------------------------------

  public override void VisitVariableElement(VariableElement element){
    if(mVariableMap.ContainsKey(element.getText())){
        MatrixElement element_value = (MatrixElement)mVariableMap[element.getText()];
      mStack.Push(element_value);
    } else {
        if (mIntVariableMap.ContainsKey(element.getText()))
        {
            IntegerElement element_value = (IntegerElement)mIntVariableMap[element.getText()];
            mIntStack.Push(element_value);
        }
        else
        {
            //lets assume that the syntax has been checked for this example because I don't like the exception
            //propegation that will happen if I throw here
            //throw new Exception("Variable " + element.getText() + " not defined.");
        }
    }
  }

  //----< visit Integer >------------------------------

  public override void VisitIntegerElement(IntegerElement element){
    int element_value = int.Parse(element.getText());
    mIntStack.Push(element);
  }

  //----< visit Assignment Operation >------------------------------

  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    String variable_name = element.getLhs().getText();

    Element rhs = element.getRhs();
    VisitElement(rhs);
    if (rhs is MatrixElement)
    {
        MatrixElement result = mStack.Pop();
        mVariableMap[variable_name] = result;
    }
    if (rhs is IntegerElement)
    {
        IntegerElement result = mIntStack.Pop();
        mIntVariableMap[variable_name] = result;
    }
    if (rhs is MatrixAdditionOperationElement)
    {
        MatrixAdditionOperationElement maoe = (MatrixAdditionOperationElement)rhs;
        if (maoe.getLhs() is IntegerElement)
        {
            IntegerElement result = mIntStack.Pop();
            mIntVariableMap[variable_name] = result;
        }
        if (maoe.getLhs() is MatrixElement)
        {
            MatrixElement result = mStack.Pop();
            mVariableMap[variable_name] = result;
        }
        if (maoe.getLhs() is VariableElement)
        {
            MatrixElement result = mStack.Pop();
            mVariableMap[variable_name] = result;
        }
    }
    if (rhs is MatrixMultiplicationOperationElement)
    {
        MatrixMultiplicationOperationElement mmoe = (MatrixMultiplicationOperationElement)rhs;
        {
            MatrixElement result = mStack.Pop();
            mVariableMap[variable_name] = result;
        }
    }
  }

  //----< visit Addition Operation >------------------------------

  public override void VisitAdditionOperationElement(AdditionOperationElement element)
  {
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      int rhs = int.Parse(mIntStack.Pop().getText());
      int lhs = int.Parse(mIntStack.Pop().getText());
      IntegerElement result = new IntegerElement();
      result.setText((lhs + rhs).ToString());
      mIntStack.Push(result);
  }

  //----< visit Matrix Addition Operation >------------------------------

  public override void VisitMatrixAdditionOperationElement(MatrixAdditionOperationElement element){
    VisitElement(element.getLhs());
    VisitElement(element.getRhs());
    MatrixElement rhs = mStack.Pop();
    MatrixElement lhs = mStack.Pop();
    MatrixElement result = new MatrixElement();
    bool ret = lhs.Addition(lhs, rhs, ref result);
    mStack.Push(result);
  }

  //----< visit Matrix Multiplication Operation >------------------------------

  public override void VisitMatrixMultiplicationOperationElement(MatrixMultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      MatrixElement rhs = mStack.Pop();
      MatrixElement lhs = mStack.Pop();
      MatrixElement result = new MatrixElement();
      bool ret = lhs.Multiplication(lhs, rhs, ref result);
      mStack.Push(result);
  }

  //----< Helpper function for print a matrix >------------------------------
    
  private void PrintRow(List<RowElement> rows, int index)
  {
      RowElement r = rows[index];
      if (r.Count() < 1)
      {
          return;
      }
      else
      {
          Console.Write(r.getElement(0));
          dele(r.getElement(0).ToString());
          for (int i = 1; i < r.Count(); ++i)
          {
              Console.Write(", " + r.getElement(i));
              dele(", " + r.getElement(i).ToString());
          }
      }
  }

  //----< visit Print Operation >------------------------------

  public override void VisitPrintOperationElement(PrintOperationElement element){
    VisitElement(element.getChildElement());
    VariableElement var = element.getChildElement() as VariableElement;
    if (mVariableMap.ContainsKey(var.getText()))
    {
        MatrixElement result = mStack.Pop();
        List<RowElement> rows = result.getRows();
        int numOfRows = rows.Count;
        if (numOfRows < 1)
        {
            return;
        }
        else
        {
            if (numOfRows == 1)
            {
                Console.Write("[");
                dele("[");
                PrintRow(rows, 0);
                Console.WriteLine("]");
                dele("]\n");
            }
            else
            {
                Console.Write("[");
                dele("[");
                PrintRow(rows, 0);
                for (int i = 1; i < numOfRows; ++i)
                {
                    Console.Write(";");
                    dele(";\n");
                    Console.WriteLine();
                    PrintRow(rows, i);
                }
                Console.WriteLine("]");
                dele("]\n");
            }
        }
    }
    if (mIntVariableMap.ContainsKey(var.getText()))
    {
        IntegerElement result = mIntStack.Pop();
        Console.WriteLine(int.Parse(result.getText()));
        dele(int.Parse(result.getText()).ToString());
    }
  }

  //----< visit a Vector (Row) Operation >------------------------------

  public override void VisitRowElement(RowElement element)
  {
      //Console.WriteLine("VisitRowElement");
      List<int> row = element.getRow();
      for (int i = 0; i < element.Count(); ++i)
      {
          Console.Write(row[i] + " ");
          dele(row[i].ToString() + " ");
      }
      Console.WriteLine();
      dele("\n");
  }

  //----< visit a Matrix Element >------------------------------
  public override void VisitMatrixElement(MatrixElement element)
  {
      //Console.WriteLine("VisitMatrixElement");
      //MatrixElement element_value = int.Parse(element.getText());
      mStack.Push(element);
  }

  //----< visit a Parallel Element >------------------------------
  public override void VisitParallelElement(ParallelElement element)
  {
      Console.WriteLine("VisitParallelElement");
  }

  //----< visit a Parallel For Operation >------------------------------

  public override void VisitParallelForOperationElement(ParallelForOperationElement element)
  {
      Console.WriteLine("VisitParallelFor");
      //dele("VisitParallelFor");
      element.ParallelRun();
  }

  //----< set the value of an index >------------------------------

  private bool setIndexValue(VariableElement var, VariableElement indexVar, int givenValue, ref int value)
  {
      if (var.getText() != indexVar.getText())
      {
          return false;
      }
      else
      {
          value = givenValue;
      }
      return true;
  }

  //----< evaluate the index of a VectorIndexElement >------------------------------

  private int setVectorIndexValue(VectorIndexElement element, Element var_elem)
  {
      int first_index_num = 0;
      if (var_elem is VariableElement)
      {
          VariableElement var = (VariableElement)var_elem;
          bool bRet = setIndexValue(var, element.getVariable(), element.getValue(), ref first_index_num);
      }
      else
      {
          if (var_elem is IntegerElement)
          {
              IntegerElement int_elem = (IntegerElement)var_elem;
              first_index_num = int.Parse(int_elem.getText());
          }
      }
      return first_index_num;
  }

  //----< visit VectorIndexElement >------------------------------

  public override void VisitVectorIndexElement(VectorIndexElement element)
  {
      Element first_index = element.getFirstIndexElement();
      Element second_index = element.getSecondIndexElement();
      int first_index_num = setVectorIndexValue(element, first_index);
      int second_index_num = setVectorIndexValue(element, second_index);

      VariableElement matrix_var = element.getVariableElement() as VariableElement;

      if (mVariableMap.ContainsKey(matrix_var.getText()))
      {
          MatrixElement element_value = (MatrixElement)mVariableMap[matrix_var.getText()];
          List<RowElement> rows = element_value.getRows();
          RowElement row = rows[first_index_num];

          IntegerElement new_int = new IntegerElement();
          new_int.setText(row.getElement(second_index_num).ToString());
          mIntStack.Push(new_int);
      }
  }

  //----< visit VectorIndexElement New >------------------------------

  public override void VisitVectorIndexElementNew(VectorIndexElement element)
  {
  }

  //----< visit Parallel Addition Operation >------------------------------

  public override void VisitParallelAdditionOperationElement(ParallelAdditionOperationElement element)
  {
      Console.WriteLine("VisitParallelAddition");
      //dele("VisitParallelAddition");
      ParallelElement pe_lhs;
      if (element.getLhs() is ParallelElement)
      {
          pe_lhs = (ParallelElement)element.getLhs();
          pe_lhs.setValue(element.getValue());
          pe_lhs.setVariable(element.getVariable());
      }
      VisitElement(element.getLhs());

      ParallelElement pe_rhs;
      if (element.getRhs() is ParallelElement)
      {
          pe_rhs = (ParallelElement)element.getRhs();
          pe_rhs.setValue(element.getValue());
          pe_rhs.setVariable(element.getVariable());
      }
      VisitElement(element.getRhs());

      IntegerElement rhs = mIntStack.Pop();
      IntegerElement lhs = mIntStack.Pop();
      int result_int = int.Parse(rhs.getText()) + int.Parse(lhs.getText());
      IntegerElement result = new IntegerElement();
      result.setText(result_int.ToString());
      mIntStack.Push(result);    
  }

  //----< visit Parallel Assignment Operation >------------------------------

  public override void VisitParallelAssignmentOperationElement(ParallelAssignmentOperationElement element)
  {
      // the rhs of ParallelForAssignment
      Element rhs = element.getRhs();
      ParallelElement pe_rhs = (ParallelElement)element.getRhs();
      if (element.getRhs() is ParallelElement)
      {
          pe_rhs.setValue(element.getValue());
          pe_rhs.setVariable(element.getVariable());
      }
      VisitElement(rhs);
      IntegerElement result = mIntStack.Pop();
      int result_int = int.Parse(result.getText());

      // the lhs of ParallelForAssignment
      VectorIndexElement vie = (VectorIndexElement)element.getLhs();
      ParallelElement pe_lhs = (ParallelElement)element.getLhs();
      if (element.getLhs() is ParallelElement)
      {
          pe_lhs.setValue(element.getValue());
          pe_lhs.setVariable(element.getVariable());
      }
      VariableElement vie_var = (vie.getVariableElement()) as VariableElement;
      string s = vie_var.getText();
      Element result_first_index = vie.getFirstIndexElement();
      Element result_second_index = vie.getSecondIndexElement();
      int result_first_index_num = setVectorIndexValue(vie, result_first_index);
      int result_second_index_num = setVectorIndexValue(vie, result_second_index);

      if (mVariableMap.ContainsKey(s))
      {
          MatrixElement m = (mVariableMap[s]) as MatrixElement;
          m.setValue(result_first_index_num, result_second_index_num, result_int);
          Console.WriteLine(m.ToString());
      }
  }
}

////////////////////////////////////////////////////////////////////////
// InterpreterVisitor.cs: Implements a vistor that interprets the 
//  syntax tree.
// 
// version: 1.1
// description: part of the interpreter example for the visitor design
//  pattern.
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
  SampleDelegate d1;

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mIntVariableMap = new Hashtable();
    mStack = new Stack<MatrixElement>();
    mIntStack = new Stack<IntegerElement>();
    mDict = new Dictionary<string, Element>();
    mQueue = new Queue<int>();
  }

  public void setDelegate(SampleDelegate value) { d1 = value; }

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
  public override void VisitIntegerElement(IntegerElement element){
    int element_value = int.Parse(element.getText());
    //mQueue.Enqueue(element_value);
    mIntStack.Push(element);
  }
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
    }
    if (rhs is MatrixMultiplicationOperationElement)
    {
        MatrixMultiplicationOperationElement mmoe = (MatrixMultiplicationOperationElement)rhs;
        //if (mmoe.getLhs() is MatrixElement)
        {
            MatrixElement result = mStack.Pop();
            mVariableMap[variable_name] = result;
        }
    }
  }
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
  public override void VisitMatrixAdditionOperationElement(MatrixAdditionOperationElement element){
    VisitElement(element.getLhs());
    VisitElement(element.getRhs());
    if (element.getLhs() is MatrixElement)
    {
        MatrixElement rhs = mStack.Pop();
        MatrixElement lhs = mStack.Pop();
        MatrixElement result = new MatrixElement();
        bool ret = lhs.Addition(lhs, rhs, ref result);
        mStack.Push(result);
    }
    if (element.getLhs() is IntegerElement)
    {
        IntegerElement rhs = mIntStack.Pop();
        IntegerElement lhs = mIntStack.Pop();
        IntegerElement result = new IntegerElement();
        result.setText((int.Parse(lhs.getText()) + int.Parse(rhs.getText())).ToString());
        mIntStack.Push(result);
    }
    if (element.getLhs() is VariableElement)
    {

    }
  }
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
          d1(r.getElement(0).ToString());
          for (int i = 1; i < r.Count(); ++i)
          {
              Console.Write(", " + r.getElement(i));
              d1(", " + r.getElement(i).ToString());
          }
      }
  }

  public override void VisitPrintOperationElement(PrintOperationElement element){
    VisitElement(element.getChildElement());
    VariableElement var = element.getChildElement() as VariableElement;
    //MatrixElement result = new MatrixElement();
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
                d1("[");
                PrintRow(rows, 0);
                Console.WriteLine("]");
                d1("]\n");
            }
            else
            {
                Console.Write("[");
                d1("[");
                PrintRow(rows, 0);
                for (int i = 1; i < numOfRows; ++i)
                {
                    Console.Write(";");
                    d1(";");
                    d1("\n");
                    Console.WriteLine();
                    PrintRow(rows, i);
                }
                Console.WriteLine("]");
                d1("]\n");
            }
        }
    }
    if (mIntVariableMap.ContainsKey(var.getText()))
    {
        IntegerElement result = mIntStack.Pop();
        Console.WriteLine(int.Parse(result.getText()));
        d1(int.Parse(result.getText()).ToString());
    }
    //MatrixElement result = mStack.Pop();
    //Console.WriteLine(result.ToString());

    
  }

  public override void VisitRowElement(RowElement element)
  {
      //Console.WriteLine("VisitRowElement");
      List<int> row = element.getRow();
      for (int i = 0; i < element.Count(); ++i)
      {
          Console.Write(row[i] + " ");
          d1(row[i].ToString() + " ");
      }
      Console.WriteLine();
      d1("\n");
  }

  public override void VisitMatrixElement(MatrixElement element)
  {
      //Console.WriteLine("VisitMatrixElement");
      //MatrixElement element_value = int.Parse(element.getText());
      mStack.Push(element);
  }

  public override void VisitParallelElement(ParallelElement element)
  {
      Console.WriteLine("VisitParallelElement");
  }

  public override void VisitParallelForOperationElement(ParallelForOperationElement element)
  {
      Console.WriteLine("VisitParallelFor");
      //d1("VisitParallelFor");
      element.Beta();
  }

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

  public override void VisitVectorIndexElement(VectorIndexElement element)
  {
      int first_index_num = 0;
      int second_index_num = 0;
      Element first_index = element.getFirstIndexElement();
      Element second_index = element.getSecondIndexElement();
      if (first_index is VariableElement)
      {
          VariableElement var = (VariableElement)first_index;
          bool bRet = setIndexValue(var, element.getVariable(), element.getValue(), ref first_index_num);
      }
      else
      {
          if (first_index is IntegerElement)
          {
              IntegerElement int_elem = (IntegerElement)first_index;
              first_index_num = int.Parse(int_elem.getText());
          }
      }

      if (second_index is VariableElement)
      {
          VariableElement var = (VariableElement)second_index;
          bool bRet = setIndexValue(var, element.getVariable(), element.getValue(), ref second_index_num);
      }
      else
      {
          if (second_index is IntegerElement)
          {
              IntegerElement int_elem = (IntegerElement)second_index;
              second_index_num = int.Parse(int_elem.getText());
          }
      }

      VariableElement paoeLhs_var = element.getVariableElement() as VariableElement;
      VectorIndexElement new_vie = new VectorIndexElement();
      new_vie.setVariableElement(paoeLhs_var);
      IntegerElement new_first = new IntegerElement();
      new_first.setText(first_index_num.ToString());
      IntegerElement new_second = new IntegerElement();
      new_second.setText(second_index_num.ToString());
      new_vie.setFirstIndexElement(new_first);
      new_vie.setSecondIndexElement(new_second);

      VariableElement matrix_var = (new_vie.getVariableElement()) as VariableElement;
      IntegerElement first = (new_vie.getFirstIndexElement()) as IntegerElement;
      IntegerElement second = (new_vie.getSecondIndexElement()) as IntegerElement;
      Console.WriteLine("VisitVectorIndex " + matrix_var.getText() + " " + first.getText() + " " + second.getText());
      //d1("VisitVectorIndex " + matrix_var.getText() + " " + first.getText() + " " + second.getText());

      if (mVariableMap.ContainsKey(matrix_var.getText()))
      {
          MatrixElement element_value = (MatrixElement)mVariableMap[matrix_var.getText()];
          List<RowElement> rows = element_value.getRows();
          RowElement row = rows[int.Parse(first.getText())];

          IntegerElement new_int = new IntegerElement();
          new_int.setText(row.getElement(int.Parse(second.getText())).ToString());
          mIntStack.Push(new_int);
          Console.WriteLine(" element " + row.getElement(int.Parse(second.getText())).ToString());
      }

  }

  public override void VisitVectorIndexElementNew(VectorIndexElement element)
  {
  }

  public override void VisitParallelAdditionOperationElement(ParallelAdditionOperationElement element)
  {
      Console.WriteLine("VisitParallelAddition");
      //d1("VisitParallelAddition");
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

  public override void VisitParallelAssignmentOperationElement(ParallelAssignmentOperationElement element)
  {
      Console.WriteLine("VisitParallelAssignment");
      //d1("VisitParallelAssignment");

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

      //VectorIndexElement vie = element.getLhs();
      //VariableElement vie_var = (vie.getVariableElement()) as VariableElement;
      //string s = vie_var.getText();
      //IntegerElement first_index = (vie.getFirstIndexElement()) as IntegerElement;
      //IntegerElement second_index = (vie.getSecondIndexElement()) as IntegerElement;
      //int row = int.Parse(first_index.getText());
      //int col = int.Parse(second_index.getText());

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
      int result_first_index_num = 0;
      int result_second_index_num = 0;
      Element result_first_index = vie.getFirstIndexElement();
      Element result_second_index = vie.getSecondIndexElement();
      if (result_first_index is VariableElement)
      {
          VariableElement var = (VariableElement)result_first_index;
          VariableElement iteration_var = (VariableElement)(vie.getVariable());
          if (var.getText() != iteration_var.getText())
          {
              //d1("incorrect index");
          }
          else
          {
              result_first_index_num = vie.getValue();
          }
      }
      else
      {
          if (result_first_index is IntegerElement)
          {
              IntegerElement int_elem = (IntegerElement)result_first_index;
              result_first_index_num = int.Parse(int_elem.getText());
          }
      }

      if (result_second_index is VariableElement)
      {
          VariableElement var = (VariableElement)result_second_index;
          VariableElement childElement = (VariableElement)(vie.getVariable());
          if (var.getText() != childElement.getText())
          {
              //d1("incorrect index");
          }
          else
          {
              result_second_index_num = vie.getValue();
          }
      }
      else
      {
          if (result_second_index is IntegerElement)
          {
              IntegerElement int_elem = (IntegerElement)result_second_index;
              result_second_index_num = int.Parse(int_elem.getText());
          }
      }

      if (mVariableMap.ContainsKey(s))
      {
          MatrixElement m = (mVariableMap[s]) as MatrixElement;
          m.setValue(result_first_index_num, result_second_index_num, result_int);
          Console.WriteLine(m.ToString());
      }
  }
}

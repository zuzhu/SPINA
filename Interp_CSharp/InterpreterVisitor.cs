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

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mIntVariableMap = new Hashtable();
    mStack = new Stack<MatrixElement>();
    mIntStack = new Stack<IntegerElement>();
    mDict = new Dictionary<string, Element>();
    mQueue = new Queue<int>();
  }

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
          for (int i = 1; i < r.Count(); ++i)
          {
              Console.Write(", " + r.getElement(i));
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
                PrintRow(rows, 0);
                Console.WriteLine("]");
            }
            else
            {
                Console.Write("[");
                PrintRow(rows, 0);
                for (int i = 1; i < numOfRows; ++i)
                {
                    Console.Write(";");
                    Console.WriteLine();
                    PrintRow(rows, i);
                }
                Console.WriteLine("]");
            }
        }
    }
    if (mIntVariableMap.ContainsKey(var.getText()))
    {
        IntegerElement result = mIntStack.Pop();
        Console.WriteLine(int.Parse(result.getText()));
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
      }
      Console.WriteLine();
  }

  public override void VisitMatrixElement(MatrixElement element)
  {
      //Console.WriteLine("VisitMatrixElement");
      //MatrixElement element_value = int.Parse(element.getText());
      mStack.Push(element);
  }


  public override void VisitParallelForOperationElement(ParallelForOperationElement element)
  {
      Console.WriteLine("VisitParallelFor");
      element.Beta();
      //int lower = element.getLowRange();
      //int upper = element.getHighRange();
      //for (int i = lower; i <= upper; ++i)
      //{
      //    //myThread m = new myThread();
      //    Thread oThread = new Thread(new ThreadStart(element.Beta));
      //    oThread.Start();

      //}
  }

  public override void VisitVectorIndexElement(VectorIndexElement element)
  {
      Console.WriteLine("VisitVectorIndex");

  }
  public override void VisitParallelAdditionOperationElement(ParallelAdditionOperationElement element)
  {
      Console.WriteLine("VisitParallelAddition");

  }
  public override void VisitParallelAssignmentOperationElement(ParallelAssignmentOperationElement element)
  {
      Console.WriteLine("VisitParallelAssignment");

  }
}

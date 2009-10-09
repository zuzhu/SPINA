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

public class InterpreterVisitor : Visitor {

  Hashtable mVariableMap;
  Stack<MatrixElement> mStack;
  Dictionary<String, Element> mDict;
  Queue<int> mQueue;

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mStack = new Stack<MatrixElement>();
    mDict = new Dictionary<string, Element>();
    mQueue = new Queue<int>();
  }

  public override void VisitVariableElement(VariableElement element){
    if(mVariableMap.ContainsKey(element.getText())){
        MatrixElement element_value = (MatrixElement)mVariableMap[element.getText()];
      mStack.Push(element_value);
    } else {
      //lets assume that the syntax has been checked for this example because I don't like the exception
      //propegation that will happen if I throw here
      //throw new Exception("Variable " + element.getText() + " not defined.");
    }
  }
  public override void VisitIntegerElement(IntegerElement element){
    int element_value = int.Parse(element.getText());
    mQueue.Enqueue(element_value);
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    String variable_name = element.getLhs().getText();

    Element rhs = element.getRhs();
    VisitElement(rhs);
    MatrixElement result = mStack.Pop();    
    mVariableMap[variable_name] = result;
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element){
    VisitElement(element.getLhs());
    VisitElement(element.getRhs());
    MatrixElement rhs = mStack.Pop();
    MatrixElement lhs = mStack.Pop();
    MatrixElement result = new MatrixElement();
    bool ret = lhs.Addition(lhs, rhs, ref result);
    mStack.Push(result);    
  }
  public override void VisitPrintOperationElement(PrintOperationElement element){
    VisitElement(element.getChildElement());
    MatrixElement result = mStack.Pop();
    Console.WriteLine(result.ToString());
  }

  public override void VisitRowElement(RowElement element)
  {
      Console.WriteLine("VisitRowElement");
      List<int> row = element.getRow();
      for (int i = 0; i < element.Count(); ++i)
      {
          Console.Write(row[i] + " ");
      }
      Console.WriteLine();
  }

  public override void VisitMatrixElement(MatrixElement element)
  {
      Console.WriteLine("VisitMatrixElement");
      //MatrixElement element_value = int.Parse(element.getText());
      mStack.Push(element);
  }
}

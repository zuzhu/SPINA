////////////////////////////////////////////////////////////////////////
// PrettyPrintVisitor.cs: demonstrates printing the syntax tree in 
//  a difference source language than the input for the Interp language.
// 
// version: 1.1
// description: add support for new Elements
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

public class PrettyPrintVisitor : Visitor {

  WriteBufferDelegate dele;

  //----< set Delegate >------------------------------

  public void setDelegate(WriteBufferDelegate value) { dele = value; }

  //----< VisitVariableElement >------------------------------

  public override void VisitVariableElement(VariableElement element){
    Console.Write("var:" + element.getText() + " ");
    dele("var:" + element.getText() + " ");
  }

  //----< VisitIntegerElement >------------------------------

  public override void VisitIntegerElement(IntegerElement element){
    Console.Write("int:" + element.getText() + " ");
    dele("int:" + element.getText() + " ");
  }

  //----< VisitAssignmentOperationElement >------------------------------

  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    VisitElement(element.getLhs());
    Console.Write(":= ");
    dele(":= ");
    VisitElement(element.getRhs());
    Console.WriteLine(";");
    dele(";\n");
  }

  //----< VisitAdditionOperationElement >------------------------------

  public override void VisitAdditionOperationElement(AdditionOperationElement element)
  {
      VisitElement(element.getLhs());
      Console.Write("+ ");
      dele("+ ");
      VisitElement(element.getRhs());
      Console.Write(" ");
      dele(" ");
  }

  //----< VisitMatrixAdditionOperationElement >------------------------------

  public override void VisitMatrixAdditionOperationElement(MatrixAdditionOperationElement element){
    VisitElement(element.getLhs());
    Console.Write("+ ");
    dele("+ ");
    VisitElement(element.getRhs());
    Console.Write(" ");
    dele(" ");
  }

  //----< VisitMatrixMultiplicationOperationElement >------------------------------

  public override void VisitMatrixMultiplicationOperationElement(MatrixMultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      Console.Write("* ");
      dele("* ");
      VisitElement(element.getRhs());
      Console.Write(" ");
      dele(" ");
  }

  //----< VisitPrintOperationElement >------------------------------

  public override void VisitPrintOperationElement(PrintOperationElement element){
    Console.Write("function:print ");
    dele("function:print ");
    VisitElement(element.getChildElement());
    Console.WriteLine(";");
    dele(";\n");
  }

  //----< VisitRowElement >------------------------------

  public override void VisitRowElement(RowElement element)
  {
      Console.WriteLine("VisitRowElement");
  }

  //----< VisitVectorIndexElement >------------------------------

  public override void VisitVectorIndexElement(VectorIndexElement element)
  {
      Console.WriteLine("VisitVectorIndexElement");
  }

  //----< VisitVectorIndexElementNew >------------------------------

  public override void VisitVectorIndexElementNew(VectorIndexElement element)
  {
      Console.WriteLine("VisitVectorIndexElementNew");
  }

  //----< VisitParallelElement >------------------------------

  public override void VisitParallelElement(ParallelElement element)
  {
      Console.WriteLine("VisitParallelElement");
  }

  //----< VisitParallelForOperationElement >------------------------------

  public override void VisitParallelForOperationElement(ParallelForOperationElement element)
  {
      Console.WriteLine("VisitParallelFor ...");
  }

  //----< VisitParallelAdditionOperationElement >------------------------------

  public override void VisitParallelAdditionOperationElement(ParallelAdditionOperationElement element)
  {
      Console.WriteLine("VisitParallelAdd ...");
  }

  //----< VisitParallelAssignmentOperationElement >------------------------------

  public override void VisitParallelAssignmentOperationElement(ParallelAssignmentOperationElement element)
  {
      Console.WriteLine("VisitParallelAssignment ...");
  }

  //----< display a vector >------------------------------

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

  //----< display the matrix >------------------------------

  public override void VisitMatrixElement(MatrixElement element)
  {
      List<RowElement> rows = element.getRows();
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
}

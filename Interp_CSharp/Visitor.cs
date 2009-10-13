////////////////////////////////////////////////////////////////////////
// Visitor.cs: declares all the abstract Visit functions that each
//  visitor must implement.  Also includes the VisitElement function
//  which alows visiting of an Element when its type is not known.
// 
// version: 1.1
// description: add new visiting functions for SPINA
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public abstract class Visitor {

  public abstract void VisitVariableElement(VariableElement element);
  public abstract void VisitIntegerElement(IntegerElement element);
  public abstract void VisitRowElement(RowElement element);
  public abstract void VisitMatrixElement(MatrixElement element);
  public abstract void VisitAssignmentOperationElement(AssignmentOperationElement element);
  public abstract void VisitAdditionOperationElement(AdditionOperationElement element);
  public abstract void VisitMatrixAdditionOperationElement(MatrixAdditionOperationElement element);
  public abstract void VisitMatrixMultiplicationOperationElement(MatrixMultiplicationOperationElement element);
  public abstract void VisitPrintOperationElement(PrintOperationElement element);
  public abstract void VisitParallelForOperationElement(ParallelForOperationElement element);
  public abstract void VisitVectorIndexElement(VectorIndexElement element);
  public abstract void VisitParallelAdditionOperationElement(ParallelAdditionOperationElement element);
  public abstract void VisitParallelAssignmentOperationElement(ParallelAssignmentOperationElement element);
  public abstract void VisitVectorIndexElementNew(VectorIndexElement element);
  public abstract void VisitParallelElement(ParallelElement element);

  //----< visit unknown type element >------------------------------

  public void VisitElement(Element element){
    if(element is IntegerElement){
      IntegerElement int_elem = (IntegerElement) element;
      VisitIntegerElement(int_elem);       
    } else if(element is VariableElement){
      VariableElement var_elem = (VariableElement) element;
      VisitVariableElement(var_elem);
    } else if (element is AdditionOperationElement) {
      AdditionOperationElement add_elem = (AdditionOperationElement)element;
      VisitAdditionOperationElement(add_elem);
    } else if (element is MatrixAdditionOperationElement) {
      MatrixAdditionOperationElement add_elem = (MatrixAdditionOperationElement) element;
      VisitMatrixAdditionOperationElement(add_elem);
    } else if (element is MatrixMultiplicationOperationElement) {
      MatrixMultiplicationOperationElement multi_elem = (MatrixMultiplicationOperationElement)element;
      VisitMatrixMultiplicationOperationElement(multi_elem);
    } else if (element is AssignmentOperationElement) {
      AssignmentOperationElement assign_elem = (AssignmentOperationElement) element;
      VisitAssignmentOperationElement(assign_elem);
    } else if (element is RowElement){
      RowElement row_elem = (RowElement)element;
      VisitRowElement(row_elem);
    } else if (element is MatrixElement) {
      MatrixElement matrix_elem = (MatrixElement)element;
      VisitMatrixElement(matrix_elem);
    } else if (element is PrintOperationElement) {
      MatrixElement matrix_elem = (MatrixElement)element;
      VisitMatrixElement(matrix_elem);
    } else if (element is ParallelForOperationElement) {
      ParallelForOperationElement pf = (ParallelForOperationElement)element;
      VisitParallelForOperationElement(pf);
    } else if (element is VectorIndexElement) {
      VectorIndexElement vec_elem = (VectorIndexElement)element;
      VisitVectorIndexElement(vec_elem);
    } else if (element is ParallelAssignmentOperationElement) {
      ParallelAssignmentOperationElement paoe = (ParallelAssignmentOperationElement)element;
      VisitParallelAssignmentOperationElement(paoe);
    } else if (element is ParallelAdditionOperationElement) {
      ParallelAdditionOperationElement paoe = (ParallelAdditionOperationElement)element;
      VisitParallelAdditionOperationElement(paoe);
    }
  }

  protected Visitor() { }
}

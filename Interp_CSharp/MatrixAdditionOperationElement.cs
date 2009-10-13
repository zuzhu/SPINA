////////////////////////////////////////////////////////////////////////
// MatrixAdditionOperationElement.cs: holds the data needed for an matrix addition 
//  operation.
// 
// version: 1.0
// description: derived from phil's addition operation class
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class MatrixAdditionOperationElement : Element {

  Element mLhs;
  Element mRhs;  

  public override void Accept(Visitor visitor){
    visitor.VisitMatrixAdditionOperationElement(this);
  }

  public Element getLhs() { return mLhs; }
  public void setLhs(Element lhs) { mLhs = lhs; }

  public Element getRhs() { return mRhs; }
  public void setRhs(Element rhs) { mRhs = rhs; }
}

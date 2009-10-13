////////////////////////////////////////////////////////////////////////
// MatrixMultiplicationOperationElement.cs: holds the data needed for 
//  a matrix multiplication operation.
// 
// version: 1.0
// description: matrix multiplication operation
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class MatrixMultiplicationOperationElement : Element
{

    Element mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixMultiplicationOperationElement(this);
    }

    public Element getLhs() { return mLhs; }
    public void setLhs(Element lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }
}

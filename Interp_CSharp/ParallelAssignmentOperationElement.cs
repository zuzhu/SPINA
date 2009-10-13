////////////////////////////////////////////////////////////////////////
// ParallelAssignmentOperationElement.cs: holds the data needed for a
//  parallel assignment operation.
// 
// version: 1.1
// description: derived from phil's AssignmentOperationElement class
//   this class is also derived from ParallelElement
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class ParallelAssignmentOperationElement : ParallelElement
{

    VectorIndexElement mLhs;
    Element mRhs;

    //----< override Accept() of Element >------------------------------

    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelAssignmentOperationElement(this);
    }

    //----< getters and setters >------------------------------

    public VectorIndexElement getLhs() { return mLhs; }
    public void setLhs(VectorIndexElement lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }

}

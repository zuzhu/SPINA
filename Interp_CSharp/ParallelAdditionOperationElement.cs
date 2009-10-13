////////////////////////////////////////////////////////////////////////
// ParallelAdditionOperationElement.cs: holds the data needed for a 
//  parallel addition operation.
// 
// version: 1.1
// description: parallel addition operation, it derives from ParallelElement
//   base class
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class ParallelAdditionOperationElement : ParallelElement
{

    Element mLhs;
    Element mRhs;

    //----< override Accept() of Element >------------------------------
    
    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelAdditionOperationElement(this);
    }

    //----< getters and setters >------------------------------

    public Element getLhs() { return mLhs; }
    public void setLhs(Element lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }

}

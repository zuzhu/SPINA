////////////////////////////////////////////////////////////////////////
// AssignmentOperationElement.cs: holds the data needed for an 
//  assignment operation.
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

public class ParallelAssignmentOperationElement : ParallelElement
{

    VectorIndexElement mLhs;
    Element mRhs;
    //VariableElement mVar;
    //int value;
    //bool isVarSet = false;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelAssignmentOperationElement(this);
    }

    public VectorIndexElement getLhs() { return mLhs; }
    public void setLhs(VectorIndexElement lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }

    //public int getValue() { return value; }
    //public void setValue(int value) { this.value = value; }

    //public VariableElement getVariable() { return mVar; }
    //public void setVariable(VariableElement var) { mVar = var; isVarSet = true; }
    //public bool getVarSetFlag() { return isVarSet; }
}

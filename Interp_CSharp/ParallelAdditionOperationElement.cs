////////////////////////////////////////////////////////////////////////
// AdditionOperationElement.java: holds the data needed for an addition 
//  operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: Java 1.6.0.0
////////////////////////////////////////////////////////////////////////

public class ParallelAdditionOperationElement : ParallelElement
{

    Element mLhs;
    Element mRhs;
    //VariableElement mVar;
    //int value;
    //bool isVarSet = false;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelAdditionOperationElement(this);
    }

    public Element getLhs() { return mLhs; }
    public void setLhs(Element lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }

    //public int getValue() { return value; }
    //public void setValue(int value) { this.value = value; }

    //public VariableElement getVariable() { return mVar; }
    //public void setVariable(VariableElement var) { mVar = var; isVarSet = true; }
    //public bool getVarSetFlag() { return isVarSet; }
}

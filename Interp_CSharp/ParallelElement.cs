////////////////////////////////////////////////////////////////////////
// ParallelElement.cs: declares the VariableElement which is the iterator
//   and allow the user to specify the value for the iterator
// 
// version: 1.0
// description: the base class for parallel-for operation
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class ParallelElement : Element
{
    VariableElement mVar;   // the iterator
    int value;  // the value for iterator
    bool isVarSet = false;

    //----< override Accept() of Element >------------------------------

    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelElement(this);
    }

    //----< getters and setters >------------------------------

    public int getValue() { return value; }
    public void setValue(int value) { this.value = value; }

    public VariableElement getVariable() { return mVar; }
    public void setVariable(VariableElement var) { mVar = var; isVarSet = true; }

    public bool getVarSetFlag() { return isVarSet; }
}

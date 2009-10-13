////////////////////////////////////////////////////////////////////////
// Element.cs: declares the Accept function that takes a visitor 
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

public class ParallelElement : Element
{
    VariableElement mVar;
    int value;
    bool isVarSet = false;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelElement(this);
    }

    public int getValue() { return value; }
    public void setValue(int value) { this.value = value; }

    public VariableElement getVariable() { return mVar; }
    public void setVariable(VariableElement var) { mVar = var; isVarSet = true; }
    public bool getVarSetFlag() { return isVarSet; }
}

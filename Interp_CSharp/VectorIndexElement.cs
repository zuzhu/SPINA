////////////////////////////////////////////////////////////////////////
// PrintOperationElement.cs: hold the data needed to implement the
//  'print' function in the Interp language.
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

public class VectorIndexElement : Element
{

    Element mChildElement;
    Element mFirstIndexElement;
    Element mSecondIndexElement;

    //public VectorIndexElement()
    //{
    //}

    public Element getVariableElement() { return mChildElement; }
    public void setVariableElement(Element value) { mChildElement = value; }

    public Element getFirstIndexElement() { return mFirstIndexElement; }
    public void setFirstIndexElement(Element value) { mFirstIndexElement = value; }

    public Element getSecondIndexElement() { return mSecondIndexElement; }
    public void setSecondIndexElement(Element value) { mSecondIndexElement = value; }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitVectorIndexElement(this);
    }
}

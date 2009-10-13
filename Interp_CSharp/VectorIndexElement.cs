////////////////////////////////////////////////////////////////////////
// VectorIndexElement.cs: hold the data needed to implement the
//  things like "a[1][2]" in the Interp language.
// 
// version: 1.0
// description: it is used in the parallel-for. therefore, it is derived
//   from the ParallelElement
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class VectorIndexElement : ParallelElement
{

    Element mChildElement;
    Element mFirstIndexElement;
    Element mSecondIndexElement;
    bool hasSecond = false;

    //----< getters and setters >------------------------------

    public Element getVariableElement() { return mChildElement; }
    public void setVariableElement(Element value) { mChildElement = value; }

    public Element getFirstIndexElement() { return mFirstIndexElement; }
    public void setFirstIndexElement(Element value) { mFirstIndexElement = value; }

    public Element getSecondIndexElement() { return mSecondIndexElement; }
    public void setSecondIndexElement(Element value) { mSecondIndexElement = value; hasSecond = true; }

    public bool HasSecond() { return hasSecond; }
    public void setHasSecond(bool value) { hasSecond = value; }

    //----< Accept >------------------------------

    public override void Accept(Visitor visitor)
    {
        visitor.VisitVectorIndexElement(this);
    }
}

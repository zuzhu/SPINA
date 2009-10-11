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
using System.Collections.Generic;
using System;
using System.Threading;

public class ParallelForOperationElement : Element
{

    Element mChildElement;
    List<Element> mExpressionElement;
    int lowbound;
    int uppbound;

    public ParallelForOperationElement()
    {
        mExpressionElement = new List<Element>();
    }

    public Element getChildElement() { return mChildElement; }
    public void setChildElement(Element value) { mChildElement = value; }

    public List<Element> getExpressionElement() { return mExpressionElement; }
    public void addExpression(Element e) { mExpressionElement.Add(e); }

    public int getLowRange() { return lowbound; }
    public void setLowRange(IntegerElement e) { lowbound = int.Parse(e.getText()); }

    public int getHighRange() { return uppbound; }
    public void setHighRange(IntegerElement e) { uppbound = int.Parse(e.getText()); }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelForOperationElement(this);
    }

    public void Beta()
    {
        for (int i = lowbound; i <= uppbound; ++i)
        {
            myThread m = new myThread();
            m.setIndex(i);
            m.setChildElement(this.mChildElement);
            Thread oThread = new Thread(new ThreadStart(m.Beta));
            oThread.Start();
        }
    }
}

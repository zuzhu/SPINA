////////////////////////////////////////////////////////////////////////
// ParallelForOperationElement.cs: hold the data needed to implement the
//  parallel-for computation in the SPINA language.
// 
// version: 1.0
// description: the class sets the data structure for parallel-for computation
//   and distribute itself to multi-thread to run the work
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System;
using System.Threading;

public class ParallelForOperationElement : Element
{

    Element mChildElement;
    List<Element> mExpressionElement;
    int lowbound;   // the lower bound of the iterator
    int uppbound;   // the upper bound of the iterator
    Visitor visitor;

    //----< constructor >------------------------------

    public ParallelForOperationElement()
    {
        mExpressionElement = new List<Element>();
    }

    //----< getters and setters >------------------------------

    public Element getChildElement() { return mChildElement; }
    public void setChildElement(Element value) { mChildElement = value; }

    public List<Element> getExpressionElement() { return mExpressionElement; }
    public void setExpressionElement(List<Element> value) { mExpressionElement = value; }
    public void addExpression(Element e) { mExpressionElement.Add(e); }

    public int getLowRange() { return lowbound; }
    public void setLowRange(IntegerElement e) { lowbound = int.Parse(e.getText()); }

    public int getHighRange() { return uppbound; }
    public void setHighRange(IntegerElement e) { uppbound = int.Parse(e.getText()); }

    //----< override Accept() of Element >------------------------------

    public override void Accept(Visitor visitor)
    {
        this.visitor = visitor;
        visitor.VisitParallelForOperationElement(this);
    }

    //----< parallel run function >------------------------------

    public void ParallelRun()
    {
        for (int i = lowbound; i <= uppbound; ++i)
        {
            myThread m = new myThread();
            m.setIndex(i);
            m.setChildElement(this.mChildElement);
            m.setExpressionElement(this.mExpressionElement);
            m.setVisitor(visitor);
            Thread oThread = new Thread(new ThreadStart(m.Run));
            oThread.Start();
        }
    }
}

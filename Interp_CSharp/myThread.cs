////////////////////////////////////////////////////////////////////////
// myThread.cs: holds the data needed for 
//  a thread for parallel-computation
// 
// version: 1.0
// description: Beta() is the thread function, it will visit all the
//   elements in order
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class myThread
{
    int index;  // the value for the iterator
    Element mChildElement;  // the iterator
    List<Element> mExpressionElement;
    Visitor visitor;

    //----< getters and setters >------------------------------

    public Element getChildElement() { return mChildElement; }
    public void setChildElement(Element value) { mChildElement = value; }

    public List<Element> getExpressionElement() { return mExpressionElement; }
    public void setExpressionElement(List<Element> value) { mExpressionElement = value; }
    public void addExpression(Element e) { mExpressionElement.Add(e); }

    public int getIndex() { return index; }
    public void setIndex(int value) { index = value; }

    //----< set the visitor >------------------------------

    public void setVisitor(Visitor value) { this.visitor = value; }

    //----< the Runner function >------------------------------

    public void Run()
    {
        Console.WriteLine("This is " + index.ToString() + " thread.");
        foreach (Element e in mExpressionElement)
        {
            ParallelElement pe = (ParallelElement)e;
            pe.setValue(index);
            VariableElement iter_var = mChildElement as VariableElement;
            pe.setVariable(iter_var);
            visitor.VisitElement(e);
        }
    }
}
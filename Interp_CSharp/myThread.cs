using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class myThread
{
    int index;
    Element mChildElement;
    List<Element> mExpressionElement;

    public Element getChildElement() { return mChildElement; }
    public void setChildElement(Element value) { mChildElement = value; }

    public List<Element> getExpressionElement() { return mExpressionElement; }
    public void addExpression(Element e) { mExpressionElement.Add(e); }

    public int getIndex() { return index; }
    public void setIndex(int value) { index = value; }

    public void Beta()
    {
        Console.WriteLine("This is " + index.ToString() + " thread.");
    }
}
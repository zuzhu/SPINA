////////////////////////////////////////////////////////////////////////
// RowElement.cs: holds the data needed to represent a Vector.
// 
// version: 1.1
// description: derived from phil's Element cs
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Text;
using System.Collections.Generic;

public class RowElement : Element
{

    List<int> rowElements;

    //----< Accept >------------------------------

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRowElement(this);
    }

    //----< constructor >------------------------------

    public RowElement()
    {
        rowElements = new List<int>();
    }

    //----< overrided ToString() >------------------------------

    public override string ToString()
    {
        StringBuilder s = new StringBuilder("");
        foreach (int item in rowElements)
        {
            s.Append(item.ToString() + ", ");
        }

        return s.ToString();
    }

    //----< getters and setters >------------------------------

    public List<int> getRow() { return rowElements; }
    public void setRow(List<int> value) { rowElements = value; }
    public int Count() { return rowElements.Count; }
    public void addElement(IntegerElement item) { rowElements.Add(Int32.Parse(item.getText())); }
    public void addElement(int item) { rowElements.Add(item); }
    public int getElement(int index) { return rowElements[index]; }
}
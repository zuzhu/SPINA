////////////////////////////////////////////////////////////////////////
// IntegerElement.cs: holds the data needed to represent an Integer.
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
using System;
using System.Text;
using System.Collections.Generic;

public class RowElement : Element
{

    List<int> rowElements;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRowElement(this);
    }

    public RowElement()
    {
        rowElements = new List<int>();
    }

    public override string ToString()
    {
        StringBuilder s = new StringBuilder("");
        foreach (int item in rowElements)
        {
            s.Append(item.ToString() + ", ");
        }

        return s.ToString();
    }

    public List<int> getRow() { return rowElements; }
    public void setRow(List<int> value) { rowElements = value; }
    public int Count() { return rowElements.Count; }
    public void addElement(IntegerElement item) { rowElements.Add(Int32.Parse(item.getText())); }
    public void addElement(int item) { rowElements.Add(item); }
    public int getElement(int index) { return rowElements[index]; }
}

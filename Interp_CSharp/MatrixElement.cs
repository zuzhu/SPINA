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

public class MatrixElement : Element
{

    int numOfRows;
    List<RowElement> rows;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixElement(this);
    }

    public MatrixElement()
    {
        rows = new List<RowElement>();
    }

    public List<RowElement> getRows() { return rows; }
    public void setRows(List<RowElement> value) { rows = value; }
    public void addRows(RowElement r) { rows.Add(r); }
    public bool isSameRowSize(RowElement r)
    {
        if (rows.Count > 0)
        {
            RowElement first = rows[0];
            if (r.Count() != first.Count())
            {
                return false;
            }
        }
        return true;
    }
    public void Check(RowElement r)
    {
        if (!isSameRowSize(r))
        {
            Console.WriteLine("The number of integers in each row is not matched.");
        }
    }

    public override string ToString()
    {
        StringBuilder s = new StringBuilder("[");
        foreach(RowElement row in rows)
        {
            foreach (int item in row.getRow())
            {
                s.Append(item.ToString() + ", ");
            }
            s.Append(";");
        }
        s.Append("]");

        return s.ToString();
    }

    public MatrixElement Addition(MatrixElement b)
    {
        Console.WriteLine("matrix addition");
        return this;
    }
}

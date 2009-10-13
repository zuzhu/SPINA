////////////////////////////////////////////////////////////////////////
// ScalarElement.cs: holds the data needed to represent a scalar.
// 
// version: 1.0
// description: it is derived from the RowElement
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Text;
using System.Collections.Generic;

public class ScalarElement : RowElement
{
    public void addRow(RowElement r)
    {
        this.setRow(r.getRow());
    }

}

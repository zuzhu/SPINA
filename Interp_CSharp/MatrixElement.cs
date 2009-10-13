////////////////////////////////////////////////////////////////////////
// MatrixElement.cs: holds the data needed to represent a Matrix.
// 
// version: 1.1
// description: Matrix Addition and Multiplication added
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
// 
// version: 1.0
// description: Basic Matrix component
// author: Zutao Zhu (zuzhu@syr.edu)
// language: C# .Net 3.5
// 
////////////////////////////////////////////////////////////////////////
using System;
using System.Text;
using System.Collections.Generic;

public class MatrixElement : Element
{

    int numOfRows;
    List<RowElement> rows;

    //----< override Accept interface from Element base class >------------------------------

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixElement(this);
    }

    //----< constructor >------------------------------

    public MatrixElement()
    {
        numOfRows = 0;
        rows = new List<RowElement>();
    }

    //----< set the value for Matrix[rowNum][colNum] >------------------------------

    public bool setValue(int rowNum, int colNum, int value)
    {
        if (rowNum > numOfRows)
            return false;
        RowElement r = rows[rowNum];
        if (colNum > r.Count())
            return false;
        (r.getRow())[colNum] = value;
        return true;
    }

    //----< return the number of rows >------------------------------

    public int GetNumOfRows()
    {
        return numOfRows;
    }

    //----< return the number of cols>------------------------------

    public int GetNumOfCols()
    {
        if (rows.Count > 0)
            return rows[0].Count();
        else
            return 0;
    }

    public List<RowElement> getRows() { return rows; }
    public void setRows(List<RowElement> value) { rows = value; }
    public void addRows(RowElement r) { rows.Add(r); numOfRows++; }

    //----< check whether one row in the matrix has the same size as the first row >------------------------------

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

    //----< wrapper function to check the row size equivalence >------------------------------

    public void Check(RowElement r)
    {
        if (!isSameRowSize(r))
        {
            Console.WriteLine("The number of integers in each row is not matched.");
        }
    }

    //----< serialize the matrix in a string >------------------------------

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

    //----< serialize the matrix to a List<int> >------------------------------

    public List<int> Serialize()
    {
        List<int> allNumbers = new List<int>();
        foreach (RowElement r in rows)
        {
            foreach (int item in r.getRow())
            {
                allNumbers.Add(item);
            }
        }
        return allNumbers;
    }

    //----< transpose of a matrix >------------------------------

    public void Reverse(out MatrixElement element)
    {
        element = new MatrixElement();

        List<int> all = Serialize();
        int cols = all.Count / numOfRows;

        for (int i = 0; i < cols; ++i)
        {
            RowElement r = new RowElement();
            for (int j = 0; j < numOfRows; ++j)
            {
                r.addElement(all[j * cols + i]);
            }
            element.addRows(r);
        }
    }

    //----< Matrix Addition O(n*m) >------------------------------

    public bool Addition(MatrixElement a, MatrixElement b, ref MatrixElement result)
    {
        Console.WriteLine("matrix addition");
        List<RowElement> aRows = a.getRows();
        List<RowElement> bRows = b.getRows();

        if (aRows.Count != bRows.Count)
            return false;

        List<RowElement> resRow = new List<RowElement>();

        for (int i = 0; i < aRows.Count; ++i)
        {
            RowElement r = new RowElement();
            for (int j = 0; j < aRows[i].Count(); ++j)
            {
                r.addElement(aRows[i].getElement(j) + bRows[i].getElement(j));
            }
            result.addRows(r);
        }

        return true;
    }

    //----< Matrix Multiplication O(n*n*n) >------------------------------

    public bool Multiplication(MatrixElement a, MatrixElement b, ref MatrixElement result)
    {
        int rowNumOfA = a.GetNumOfRows();
        int colNumOfA = a.GetNumOfCols();

        int rowNumOfB = b.GetNumOfRows();
        int colNumOfB = b.GetNumOfCols();

        MatrixElement reverseB = new MatrixElement();
        b.Reverse(out reverseB);

        List<RowElement> RowA = a.getRows();
        List<RowElement> RowBReverse = reverseB.getRows();

        for (int i = 0; i < rowNumOfA; ++i)
        {
            RowElement r = new RowElement();
            RowElement partA = RowA[i];

            for (int j = 0; j < colNumOfB; ++j)
            {
                int sum = 0;
                RowElement partB = RowBReverse[j];
                for (int k = 0; k < colNumOfA; ++k)
                {
                    int first = partA.getElement(k);
                    int second = partB.getElement(k);
                    sum += first * second;
                }
                r.addElement(sum);
            }
            result.addRows(r);
        }

        return true;
    }
}

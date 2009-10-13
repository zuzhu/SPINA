using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class myThread
{
    int index;
    Element mChildElement;
    List<Element> mExpressionElement;
    Visitor visitor;

    public Element getChildElement() { return mChildElement; }
    public void setChildElement(Element value) { mChildElement = value; }

    public List<Element> getExpressionElement() { return mExpressionElement; }
    public void setExpressionElement(List<Element> value) { mExpressionElement = value; }
    public void addExpression(Element e) { mExpressionElement.Add(e); }

    public int getIndex() { return index; }
    public void setIndex(int value) { index = value; }

    public void setVisitor(Visitor value) { this.visitor = value; }

    public void Beta()
    {
        Console.WriteLine("This is " + index.ToString() + " thread.");
        foreach (Element e in mExpressionElement)
        {
            ParallelElement pe = (ParallelElement)e;
            pe.setValue(index);
            VariableElement vvv = mChildElement as VariableElement;
            pe.setVariable(vvv);
            visitor.VisitElement(e);
            
            //if (e is ParallelAssignmentOperationElement)
            //{
            //    ParallelAssignmentOperationElement element = (ParallelAssignmentOperationElement)e;
            //    VectorIndexElement vie = element.getLhs() as VectorIndexElement;
            //    VariableElement ve = (VariableElement)mChildElement;
            //    string variable_name = ve.getText();

            //    Element lhs = element.getLhs();
            //    if (lhs is VectorIndexElement)
            //    {
            //        VectorIndexElement vie_lhs = (VectorIndexElement)lhs;
            //        vie_lhs.setValue(index);
            //        VariableElement vvv = mChildElement as VariableElement;
            //        vie_lhs.setVariable(vvv);
            //    }

            //    Element rhs = element.getRhs();
            //    if (rhs is ParallelAdditionOperationElement)
            //    {
            //        ParallelAdditionOperationElement paoe = (ParallelAdditionOperationElement)rhs;
            //        Element paoeLhs = paoe.getLhs();
            //        Element paoeRhs = paoe.getRhs();
            //        if (paoeLhs is VectorIndexElement)
            //        {
            //            VectorIndexElement paoeLhs_vi = (VectorIndexElement)paoeLhs;
            //            paoeLhs_vi.setValue(index);
            //            VariableElement vvv = mChildElement as VariableElement;
            //            paoeLhs_vi.setVariable(vvv);
            //            visitor.VisitVectorIndexElement(paoeLhs_vi);
            //        }
            //        else
            //        {
            //            if (paoeLhs is IntegerElement)
            //            {
            //                IntegerElement int_elem = (IntegerElement)paoeLhs;
            //                visitor.VisitIntegerElement(int_elem);
            //            }
            //        }

            //        if (paoeRhs is VectorIndexElement)
            //        {
            //            VectorIndexElement paoeLhs_vi = (VectorIndexElement)paoeRhs;
            //            paoeLhs_vi.setValue(index);
            //            VariableElement vvv = mChildElement as VariableElement;
            //            paoeLhs_vi.setVariable(vvv);
            //            visitor.VisitVectorIndexElement(paoeLhs_vi);
            //        }
            //        else
            //        {
            //            if (paoeRhs is IntegerElement)
            //            {
            //                IntegerElement int_elem = (IntegerElement)paoeRhs;
            //                visitor.VisitIntegerElement(int_elem);
            //            }
            //        }

            //        visitor.VisitParallelAssignmentOperationElement(element);
            //    }
            //}

            //if (e is ParallelAdditionOperationElement)
            //{
            //    ParallelAdditionOperationElement paoe = (ParallelAdditionOperationElement)e;
            //    visitor.VisitParallelAdditionOperationElement(paoe);
            //}
        }
    }
}
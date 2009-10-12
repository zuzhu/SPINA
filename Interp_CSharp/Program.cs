﻿////////////////////////////////////////////////////////////////////////
// Program.cs: demonstrates the interpreter for the Interp language.
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;

public delegate void SampleDelegate(string message);

public class consoleProgram
{
    InterpreterVisitor interp_visitor;
    PrettyPrintVisitor print_visitor;
    String line;
    SampleDelegate d1;

    public consoleProgram()
    {
        interp_visitor = new InterpreterVisitor();
        print_visitor = new PrettyPrintVisitor();
    }

    public void setText(String value) { line = value; }
    public void setDelegate(SampleDelegate value) { d1 = value; }

    public void setVisitorDelegate(SampleDelegate value) { interp_visitor.setDelegate(value); }

    public void VisitLine()
    {
        try
        {
            ANTLRStringStream string_stream = new ANTLRStringStream(line);
            InterpLexer lexer = new InterpLexer(string_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            InterpParser parser = new InterpParser(tokens);
        //}
        //catch (RecognitionException e)
        //{
        //    d1(e.Message);
        //}
        setVisitorDelegate(d1);
        //try
        //{
            InterpParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for (int i = 0; i < elements.Count; i++)
            {
                Element curr = elements[i];
                curr.Accept(print_visitor);
                curr.Accept(interp_visitor);
            }
            d1("END");
        }
        catch (RecognitionException e)
        {
            Console.WriteLine(e.Message);
            d1(e.Message);
        }

    }

    public void VisitLine(String line)
    {
        try
        {
            ANTLRStringStream string_stream = new ANTLRStringStream(line);
            InterpLexer lexer = new InterpLexer(string_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            InterpParser parser = new InterpParser(tokens);
        //}
        //catch (RecognitionException e)
        //{
        //    d1(e.Message);
        //}

        setVisitorDelegate(d1);

        //try
        //{
            InterpParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for (int i = 0; i < elements.Count; i++)
            {
                Element curr = elements[i];
                curr.Accept(print_visitor);
                curr.Accept(interp_visitor);
            }
        }
        catch (RecognitionException e)
        {
            Console.WriteLine(e.Message);
            d1(e.Message);
        }

    }

    public void RunEvalLoop()
    {
        while (true)
        {
            Console.Write("Interp> ");
            String line = Console.ReadLine();
            if (line == "reset")
                interp_visitor = new InterpreterVisitor();
            else
                VisitLine(line);
        }
    }

    public void Start()
    {
        if (!string.IsNullOrEmpty(line))
            VisitLine(line);
    }

    public static void Main(String[] args)
    {
        consoleProgram theprogram = new consoleProgram();
        theprogram.setText("a=[1,2,3;4,5,6]; b=[2;4;6]; c=a*b; print c;");
        //first demonstrate visiting premade line.
        //theprogram.VisitLine("myvariable = 1 + 2; var = myvariable + 3; print var;");
        theprogram.VisitLine();
        //theprogram.RunEvalLoop();
    }
}


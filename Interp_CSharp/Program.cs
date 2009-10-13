////////////////////////////////////////////////////////////////////////
// Program.cs: the interpreter for the Interp language.
// 
// version: 1.1
// description: add delegate to support the communication with the caller
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

public delegate void WriteBufferDelegate(string message);

public class consoleProgram
{
    InterpreterVisitor interp_visitor;
    PrettyPrintVisitor print_visitor;
    String line;
    WriteBufferDelegate dele;

    //----< constructor >------------------------------

    public consoleProgram()
    {
        interp_visitor = new InterpreterVisitor();
        print_visitor = new PrettyPrintVisitor();
    }

    //----< getters and setters >------------------------------

    public void setText(String value) { line = value; }
    public void setDelegate(WriteBufferDelegate value) { dele = value; }

    //----< set Delegate >------------------------------

    public void setVisitorDelegate(WriteBufferDelegate value) { interp_visitor.setDelegate(value); print_visitor.setDelegate(value); }

    //----< parsing the text >------------------------------

    public void VisitLine()
    {
        int i = 0;
        try
        {
            ANTLRStringStream string_stream = new ANTLRStringStream(line);
            InterpLexer lexer = new InterpLexer(string_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            InterpParser parser = new InterpParser(tokens);

            setVisitorDelegate(dele);
            InterpParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for (i = 0; i < elements.Count; i++)
            {
                Element curr = elements[i];
                curr.Accept(print_visitor);
                curr.Accept(interp_visitor);
            }
            dele("END");
        }
        catch (RecognitionException e)
        {
            Console.WriteLine(e.Message);
            dele("Syntax error in source code.\n");
            dele(e.Message);
            dele("END");
        }

    }

    //----< parsing the text >------------------------------

    public void VisitLine(String line)
    {
        try
        {
            ANTLRStringStream string_stream = new ANTLRStringStream(line);
            InterpLexer lexer = new InterpLexer(string_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            InterpParser parser = new InterpParser(tokens);

            setVisitorDelegate(dele);

            InterpParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for (int i = 0; i < elements.Count; i++)
            {
                Element curr = elements[i];
                curr.Accept(print_visitor);
                curr.Accept(interp_visitor);
            }
        }
        catch (MismatchedTokenException e)
        {
            Console.WriteLine(e.Message);
            dele(e.Message);
        }
        catch (RecognitionException e)
        {
            Console.WriteLine(e.Message);
            dele(e.Message);
        }
    }

    //----< accept input and parse line-by-line >------------------------------

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

    //----< start to parse >------------------------------

    public void Start()
    {
        if (!string.IsNullOrEmpty(line))
            VisitLine(line);
    }

    //----< deprecated, only for console application >------------------------------

    public static void Main(String[] args)
    {
        consoleProgram theprogram = new consoleProgram();
        theprogram.setText("a=[1,2,3;4,5,6]; b=[2;4;6]; c=a*b; print c;");
        theprogram.VisitLine();
    }
}


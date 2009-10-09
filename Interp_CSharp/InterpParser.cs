// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-09-26 11:58:21


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class InterpParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ASSIGNMENT", 
		"SEMI", 
		"VARIABLE", 
		"INT_LITERAL", 
		"LPAREN", 
		"RPAREN", 
		"COMMA", 
		"LBRACK", 
		"RBRACK", 
		"DOT", 
		"PLUS", 
		"MINUS", 
		"MUL", 
		"WHITESPACE", 
		"'print'"
    };

    public const int RBRACK = 12;
    public const int RPAREN = 9;
    public const int INT_LITERAL = 7;
    public const int LBRACK = 11;
    public const int T__18 = 18;
    public const int VARIABLE = 6;
    public const int COMMA = 10;
    public const int WHITESPACE = 17;
    public const int PLUS = 14;
    public const int ASSIGNMENT = 4;
    public const int MINUS = 15;
    public const int DOT = 13;
    public const int EOF = -1;
    public const int MUL = 16;
    public const int SEMI = 5;
    public const int LPAREN = 8;

    // delegates
    // delegators



        public InterpParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public InterpParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return InterpParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Interp.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // Interp.g:29:1: program returns [List<Element> ret] : ( expr )+ ;
    public InterpParser.program_return program() // throws RecognitionException [1]
    {   
        InterpParser.program_return retval = new InterpParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // Interp.g:33:3: ( ( expr )+ )
            // Interp.g:33:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:33:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == 18) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:33:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program74);
            			    	expr1 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1.Tree);
            			    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class expr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // Interp.g:35:1: expr returns [Element ret] : ( assignment | print );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.print_return print3 = null;



        try 
    	{
            // Interp.g:36:3: ( assignment | print )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == VARIABLE) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 18) )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // Interp.g:36:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr93);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    // Interp.g:37:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr101);
                    	print3 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print3.Tree);
                    	 retval.ret = ((print3 != null) ? print3.ret : null); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class assignment_return : ParserRuleReturnScope
    {
        public AssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // Interp.g:39:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | matrix | addition ) SEMI ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT5 = null;
        IToken SEMI9 = null;
        InterpParser.variable_return variable4 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal6 = null;

        InterpParser.matrix_return matrix7 = null;

        InterpParser.addition_return addition8 = null;


        object ASSIGNMENT5_tree=null;
        object SEMI9_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:43:3: ( variable ASSIGNMENT ( var_or_int_literal | matrix | addition ) SEMI )
            // Interp.g:43:5: variable ASSIGNMENT ( var_or_int_literal | matrix | addition ) SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment122);
            	variable4 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable4.Tree);
            	retval.ret.setLhs(((variable4 != null) ? variable4.ret : null)); 
            	ASSIGNMENT5=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment130); 
            		ASSIGNMENT5_tree = (object)adaptor.Create(ASSIGNMENT5);
            		adaptor.AddChild(root_0, ASSIGNMENT5_tree);

            	// Interp.g:45:5: ( var_or_int_literal | matrix | addition )
            	int alt3 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    int LA3_1 = input.LA(2);

            	    if ( (LA3_1 == PLUS) )
            	    {
            	        alt3 = 3;
            	    }
            	    else if ( (LA3_1 == SEMI) )
            	    {
            	        alt3 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d3s1 =
            	            new NoViableAltException("", 3, 1, input);

            	        throw nvae_d3s1;
            	    }
            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    int LA3_2 = input.LA(2);

            	    if ( (LA3_2 == PLUS) )
            	    {
            	        alt3 = 3;
            	    }
            	    else if ( (LA3_2 == SEMI) )
            	    {
            	        alt3 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d3s2 =
            	            new NoViableAltException("", 3, 2, input);

            	        throw nvae_d3s2;
            	    }
            	    }
            	    break;
            	case LBRACK:
            		{
            	    alt3 = 2;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d3s0 =
            		        new NoViableAltException("", 3, 0, input);

            		    throw nvae_d3s0;
            	}

            	switch (alt3) 
            	{
            	    case 1 :
            	        // Interp.g:45:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment138);
            	        	var_or_int_literal6 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal6.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal6 != null) ? var_or_int_literal6.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:46:7: matrix
            	        {
            	        	PushFollow(FOLLOW_matrix_in_assignment149);
            	        	matrix7 = matrix();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrix7.Tree);
            	        	retval.ret.setRhs(((matrix7 != null) ? matrix7.ret : null)); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:47:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment159);
            	        	addition8 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition8.Tree);
            	        	retval.ret.setRhs(((addition8 != null) ? addition8.ret : null)); 

            	        }
            	        break;

            	}

            	SEMI9=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_assignment169); 
            		SEMI9_tree = (object)adaptor.Create(SEMI9);
            		adaptor.AddChild(root_0, SEMI9_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class var_or_int_literal_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_or_int_literal"
    // Interp.g:50:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable10 = null;

        InterpParser.int_literal_return int_literal11 = null;



        try 
    	{
            // Interp.g:51:3: ( ( variable | int_literal ) )
            // Interp.g:51:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:51:6: ( variable | int_literal )
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == VARIABLE) )
            	{
            	    alt4 = 1;
            	}
            	else if ( (LA4_0 == INT_LITERAL) )
            	{
            	    alt4 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Interp.g:51:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal185);
            	        	variable10 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable10.Tree);
            	        	 retval.ret = ((variable10 != null) ? variable10.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:52:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal196);
            	        	int_literal11 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal11.Tree);
            	        	retval.ret = ((int_literal11 != null) ? int_literal11.ret : null); 

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var_or_int_literal"

    public class matrix_return : ParserRuleReturnScope
    {
        public MatrixElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrix"
    // Interp.g:54:1: matrix returns [MatrixElement ret] : '[' e1= row ( ';' e2= row )* ']' ;
    public InterpParser.matrix_return matrix() // throws RecognitionException [1]
    {   
        InterpParser.matrix_return retval = new InterpParser.matrix_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal12 = null;
        IToken char_literal13 = null;
        IToken char_literal14 = null;
        InterpParser.row_return e1 = null;

        InterpParser.row_return e2 = null;


        object char_literal12_tree=null;
        object char_literal13_tree=null;
        object char_literal14_tree=null;


          retval.ret = new MatrixElement();

        try 
    	{
            // Interp.g:58:3: ( '[' e1= row ( ';' e2= row )* ']' )
            // Interp.g:58:5: '[' e1= row ( ';' e2= row )* ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal12=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_matrix221); 
            		char_literal12_tree = (object)adaptor.Create(char_literal12);
            		adaptor.AddChild(root_0, char_literal12_tree);

            	PushFollow(FOLLOW_row_in_matrix225);
            	e1 = row();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e1.Tree);
            	 retval.ret.addRows(((e1 != null) ? e1.ret : null)); 
            	// Interp.g:59:5: ( ';' e2= row )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == SEMI) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // Interp.g:59:6: ';' e2= row
            			    {
            			    	char_literal13=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_matrix234); 
            			    		char_literal13_tree = (object)adaptor.Create(char_literal13);
            			    		adaptor.AddChild(root_0, char_literal13_tree);

            			    	PushFollow(FOLLOW_row_in_matrix238);
            			    	e2 = row();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e2.Tree);
            			    	 retval.ret.addRows(((e2 != null) ? e2.ret : null)); retval.ret.Check(((e2 != null) ? e2.ret : null)); 

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal14=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_matrix248); 
            		char_literal14_tree = (object)adaptor.Create(char_literal14);
            		adaptor.AddChild(root_0, char_literal14_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matrix"

    public class row_return : ParserRuleReturnScope
    {
        public RowElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "row"
    // Interp.g:63:1: row returns [RowElement ret] : s= int_literal ( ',' t= int_literal )* ;
    public InterpParser.row_return row() // throws RecognitionException [1]
    {   
        InterpParser.row_return retval = new InterpParser.row_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal15 = null;
        InterpParser.int_literal_return s = null;

        InterpParser.int_literal_return t = null;


        object char_literal15_tree=null;


          retval.ret = new RowElement();

        try 
    	{
            // Interp.g:67:3: (s= int_literal ( ',' t= int_literal )* )
            // Interp.g:67:5: s= int_literal ( ',' t= int_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_literal_in_row275);
            	s = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, s.Tree);
            	 retval.ret.addElement(((s != null) ? s.ret : null)); 
            	// Interp.g:68:5: ( ',' t= int_literal )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == COMMA) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // Interp.g:68:7: ',' t= int_literal
            			    {
            			    	char_literal15=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_row285); 
            			    		char_literal15_tree = (object)adaptor.Create(char_literal15);
            			    		adaptor.AddChild(root_0, char_literal15_tree);

            			    	PushFollow(FOLLOW_int_literal_in_row289);
            			    	t = int_literal();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, t.Tree);
            			    	 retval.ret.addElement(((t != null) ? t.ret : null)); 

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "row"

    public class variable_return : ParserRuleReturnScope
    {
        public VariableElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // Interp.g:71:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE16 = null;

        object VARIABLE16_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:75:3: ( VARIABLE )
            // Interp.g:75:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE16=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable318); 
            		VARIABLE16_tree = (object)adaptor.Create(VARIABLE16);
            		adaptor.AddChild(root_0, VARIABLE16_tree);

            	 retval.ret.setText(((VARIABLE16 != null) ? VARIABLE16.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class int_literal_return : ParserRuleReturnScope
    {
        public IntegerElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_literal"
    // Interp.g:77:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL17 = null;

        object INT_LITERAL17_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:81:3: ( INT_LITERAL )
            // Interp.g:81:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL17=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal339); 
            		INT_LITERAL17_tree = (object)adaptor.Create(INT_LITERAL17);
            		adaptor.AddChild(root_0, INT_LITERAL17_tree);

            	 retval.ret.setText(((INT_LITERAL17 != null) ? INT_LITERAL17.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"

    public class addition_return : ParserRuleReturnScope
    {
        public AdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "addition"
    // Interp.g:83:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal18 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal18_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:87:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:87:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition362);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal18=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition371); 
            		char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition380);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addition"

    public class print_return : ParserRuleReturnScope
    {
        public PrintOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "print"
    // Interp.g:91:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal19 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal20 = null;


        object string_literal19_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:95:3: ( 'print' var_or_int_literal )
            // Interp.g:95:5: 'print' var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal19=(IToken)Match(input,18,FOLLOW_18_in_print401); 
            		string_literal19_tree = (object)adaptor.Create(string_literal19);
            		adaptor.AddChild(root_0, string_literal19_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print403);
            	var_or_int_literal20 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal20.Tree);
            	retval.ret.setChildElement(((var_or_int_literal20 != null) ? var_or_int_literal20.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000040042UL});
    public static readonly BitSet FOLLOW_assignment_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment122 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment130 = new BitSet(new ulong[]{0x00000000000008C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment138 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_matrix_in_assignment149 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment159 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMI_in_assignment169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_matrix221 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_matrix225 = new BitSet(new ulong[]{0x0000000000001020UL});
    public static readonly BitSet FOLLOW_SEMI_in_matrix234 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_matrix238 = new BitSet(new ulong[]{0x0000000000001020UL});
    public static readonly BitSet FOLLOW_RBRACK_in_matrix248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_row275 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_COMMA_in_row285 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_row289 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition362 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition371 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_print401 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print403 = new BitSet(new ulong[]{0x0000000000000002UL});

}

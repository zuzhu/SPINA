// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-09 21:14:49


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
    // Interp.g:39:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | matrix | addition | multiplication ) SEMI ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT5 = null;
        IToken SEMI10 = null;
        InterpParser.variable_return variable4 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal6 = null;

        InterpParser.matrix_return matrix7 = null;

        InterpParser.addition_return addition8 = null;

        InterpParser.multiplication_return multiplication9 = null;


        object ASSIGNMENT5_tree=null;
        object SEMI10_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:43:3: ( variable ASSIGNMENT ( var_or_int_literal | matrix | addition | multiplication ) SEMI )
            // Interp.g:43:5: variable ASSIGNMENT ( var_or_int_literal | matrix | addition | multiplication ) SEMI
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

            	// Interp.g:45:5: ( var_or_int_literal | matrix | addition | multiplication )
            	int alt3 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case MUL:
            	    	{
            	        alt3 = 4;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    case SEMI:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d3s1 =
            	    	        new NoViableAltException("", 3, 1, input);

            	    	    throw nvae_d3s1;
            	    }

            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case MUL:
            	    	{
            	        alt3 = 4;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    case SEMI:
            	    	{
            	        alt3 = 1;
            	        }
            	        break;
            	    	default:
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
            	    case 4 :
            	        // Interp.g:48:7: multiplication
            	        {
            	        	PushFollow(FOLLOW_multiplication_in_assignment169);
            	        	multiplication9 = multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, multiplication9.Tree);
            	        	 retval.ret.setRhs(((multiplication9 != null) ? multiplication9.ret : null)); 

            	        }
            	        break;

            	}

            	SEMI10=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_assignment179); 
            		SEMI10_tree = (object)adaptor.Create(SEMI10);
            		adaptor.AddChild(root_0, SEMI10_tree);


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
    // Interp.g:51:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable11 = null;

        InterpParser.int_literal_return int_literal12 = null;



        try 
    	{
            // Interp.g:52:3: ( ( variable | int_literal ) )
            // Interp.g:52:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:52:6: ( variable | int_literal )
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
            	        // Interp.g:52:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal195);
            	        	variable11 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable11.Tree);
            	        	 retval.ret = ((variable11 != null) ? variable11.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:53:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal206);
            	        	int_literal12 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal12.Tree);
            	        	retval.ret = ((int_literal12 != null) ? int_literal12.ret : null); 

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
    // Interp.g:55:1: matrix returns [MatrixElement ret] : '[' e1= row ( ';' e2= row )* ']' ;
    public InterpParser.matrix_return matrix() // throws RecognitionException [1]
    {   
        InterpParser.matrix_return retval = new InterpParser.matrix_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal13 = null;
        IToken char_literal14 = null;
        IToken char_literal15 = null;
        InterpParser.row_return e1 = null;

        InterpParser.row_return e2 = null;


        object char_literal13_tree=null;
        object char_literal14_tree=null;
        object char_literal15_tree=null;


          retval.ret = new MatrixElement();

        try 
    	{
            // Interp.g:59:3: ( '[' e1= row ( ';' e2= row )* ']' )
            // Interp.g:59:5: '[' e1= row ( ';' e2= row )* ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal13=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_matrix231); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	PushFollow(FOLLOW_row_in_matrix235);
            	e1 = row();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e1.Tree);
            	 retval.ret.addRows(((e1 != null) ? e1.ret : null)); 
            	// Interp.g:60:5: ( ';' e2= row )*
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
            			    // Interp.g:60:6: ';' e2= row
            			    {
            			    	char_literal14=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_matrix244); 
            			    		char_literal14_tree = (object)adaptor.Create(char_literal14);
            			    		adaptor.AddChild(root_0, char_literal14_tree);

            			    	PushFollow(FOLLOW_row_in_matrix248);
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

            	char_literal15=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_matrix258); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);


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
    // Interp.g:64:1: row returns [RowElement ret] : s= int_literal ( ',' t= int_literal )* ;
    public InterpParser.row_return row() // throws RecognitionException [1]
    {   
        InterpParser.row_return retval = new InterpParser.row_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal16 = null;
        InterpParser.int_literal_return s = null;

        InterpParser.int_literal_return t = null;


        object char_literal16_tree=null;


          retval.ret = new RowElement();

        try 
    	{
            // Interp.g:68:3: (s= int_literal ( ',' t= int_literal )* )
            // Interp.g:68:5: s= int_literal ( ',' t= int_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_literal_in_row285);
            	s = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, s.Tree);
            	 retval.ret.addElement(((s != null) ? s.ret : null)); 
            	// Interp.g:69:5: ( ',' t= int_literal )*
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
            			    // Interp.g:69:7: ',' t= int_literal
            			    {
            			    	char_literal16=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_row295); 
            			    		char_literal16_tree = (object)adaptor.Create(char_literal16);
            			    		adaptor.AddChild(root_0, char_literal16_tree);

            			    	PushFollow(FOLLOW_int_literal_in_row299);
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
    // Interp.g:72:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE17 = null;

        object VARIABLE17_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:76:3: ( VARIABLE )
            // Interp.g:76:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE17=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable328); 
            		VARIABLE17_tree = (object)adaptor.Create(VARIABLE17);
            		adaptor.AddChild(root_0, VARIABLE17_tree);

            	 retval.ret.setText(((VARIABLE17 != null) ? VARIABLE17.Text : null)); 

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
    // Interp.g:78:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL18 = null;

        object INT_LITERAL18_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:82:3: ( INT_LITERAL )
            // Interp.g:82:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL18=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal349); 
            		INT_LITERAL18_tree = (object)adaptor.Create(INT_LITERAL18);
            		adaptor.AddChild(root_0, INT_LITERAL18_tree);

            	 retval.ret.setText(((INT_LITERAL18 != null) ? INT_LITERAL18.Text : null)); 

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
    // Interp.g:84:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal19 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal19_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:88:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:88:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition372);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal19=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition381); 
            		char_literal19_tree = (object)adaptor.Create(char_literal19);
            		adaptor.AddChild(root_0, char_literal19_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition390);
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

    public class multiplication_return : ParserRuleReturnScope
    {
        public MultiplicationOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplication"
    // Interp.g:92:1: multiplication returns [MultiplicationOperationElement ret] : el1= var_or_int_literal '*' el2= var_or_int_literal ;
    public InterpParser.multiplication_return multiplication() // throws RecognitionException [1]
    {   
        InterpParser.multiplication_return retval = new InterpParser.multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal20 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal20_tree=null;


          retval.ret = new MultiplicationOperationElement();

        try 
    	{
            // Interp.g:96:3: (el1= var_or_int_literal '*' el2= var_or_int_literal )
            // Interp.g:96:5: el1= var_or_int_literal '*' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication417);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal20=(IToken)Match(input,MUL,FOLLOW_MUL_in_multiplication426); 
            		char_literal20_tree = (object)adaptor.Create(char_literal20);
            		adaptor.AddChild(root_0, char_literal20_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication435);
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
    // $ANTLR end "multiplication"

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
    // Interp.g:100:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal21 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal22 = null;


        object string_literal21_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:104:3: ( 'print' var_or_int_literal )
            // Interp.g:104:5: 'print' var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal21=(IToken)Match(input,18,FOLLOW_18_in_print456); 
            		string_literal21_tree = (object)adaptor.Create(string_literal21);
            		adaptor.AddChild(root_0, string_literal21_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print458);
            	var_or_int_literal22 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal22.Tree);
            	retval.ret.setChildElement(((var_or_int_literal22 != null) ? var_or_int_literal22.ret : null)); 

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
    public static readonly BitSet FOLLOW_multiplication_in_assignment169 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMI_in_assignment179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_matrix231 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_matrix235 = new BitSet(new ulong[]{0x0000000000001020UL});
    public static readonly BitSet FOLLOW_SEMI_in_matrix244 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_matrix248 = new BitSet(new ulong[]{0x0000000000001020UL});
    public static readonly BitSet FOLLOW_RBRACK_in_matrix258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_row285 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_COMMA_in_row295 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_row299 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition372 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition381 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication417 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_MUL_in_multiplication426 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_print456 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print458 = new BitSet(new ulong[]{0x0000000000000002UL});

}

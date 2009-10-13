// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-12 23:12:39


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
		"SEP", 
		"PLUS", 
		"MINUS", 
		"MUL", 
		"WHITESPACE", 
		"'print'", 
		"'parallel-for'", 
		"'..'", 
		"'{'", 
		"'}'"
    };

    public const int RBRACK = 12;
    public const int INT_LITERAL = 7;
    public const int LBRACK = 11;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int WHITESPACE = 18;
    public const int MINUS = 16;
    public const int EOF = -1;
    public const int MUL = 17;
    public const int SEMI = 5;
    public const int LPAREN = 8;
    public const int T__19 = 19;
    public const int RPAREN = 9;
    public const int VARIABLE = 6;
    public const int SEP = 14;
    public const int COMMA = 10;
    public const int PLUS = 15;
    public const int ASSIGNMENT = 4;
    public const int DOT = 13;

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

            	    if ( (LA1_0 == VARIABLE || (LA1_0 >= 19 && LA1_0 <= 20)) )
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
    // Interp.g:35:1: expr returns [Element ret] : ( assignment | print | parallel_for );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.print_return print3 = null;

        InterpParser.parallel_for_return parallel_for4 = null;



        try 
    	{
            // Interp.g:36:3: ( assignment | print | parallel_for )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                alt2 = 1;
                }
                break;
            case 19:
            	{
                alt2 = 2;
                }
                break;
            case 20:
            	{
                alt2 = 3;
                }
                break;
            	default:
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
                case 3 :
                    // Interp.g:38:5: parallel_for
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallel_for_in_expr109);
                    	parallel_for4 = parallel_for();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallel_for4.Tree);
                    	 retval.ret = ((parallel_for4 != null) ? parallel_for4.ret : null); 

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
    // Interp.g:42:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | matrix | matrixaddition | matrixmultiplication ) SEMI ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT6 = null;
        IToken SEMI11 = null;
        InterpParser.variable_return variable5 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal7 = null;

        InterpParser.matrix_return matrix8 = null;

        InterpParser.matrixaddition_return matrixaddition9 = null;

        InterpParser.matrixmultiplication_return matrixmultiplication10 = null;


        object ASSIGNMENT6_tree=null;
        object SEMI11_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:46:3: ( variable ASSIGNMENT ( var_or_int_literal | matrix | matrixaddition | matrixmultiplication ) SEMI )
            // Interp.g:46:5: variable ASSIGNMENT ( var_or_int_literal | matrix | matrixaddition | matrixmultiplication ) SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment134);
            	variable5 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable5.Tree);
            	retval.ret.setLhs(((variable5 != null) ? variable5.ret : null)); 
            	ASSIGNMENT6=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment142); 
            		ASSIGNMENT6_tree = (object)adaptor.Create(ASSIGNMENT6);
            		adaptor.AddChild(root_0, ASSIGNMENT6_tree);

            	// Interp.g:48:5: ( var_or_int_literal | matrix | matrixaddition | matrixmultiplication )
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
            	    case PLUS:
            	    	{
            	        alt3 = 3;
            	        }
            	        break;
            	    case MUL:
            	    	{
            	        alt3 = 4;
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
            	        // Interp.g:48:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment150);
            	        	var_or_int_literal7 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal7.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal7 != null) ? var_or_int_literal7.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:50:7: matrix
            	        {
            	        	PushFollow(FOLLOW_matrix_in_assignment162);
            	        	matrix8 = matrix();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrix8.Tree);
            	        	retval.ret.setRhs(((matrix8 != null) ? matrix8.ret : null)); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:51:7: matrixaddition
            	        {
            	        	PushFollow(FOLLOW_matrixaddition_in_assignment172);
            	        	matrixaddition9 = matrixaddition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixaddition9.Tree);
            	        	retval.ret.setRhs(((matrixaddition9 != null) ? matrixaddition9.ret : null)); 

            	        }
            	        break;
            	    case 4 :
            	        // Interp.g:52:7: matrixmultiplication
            	        {
            	        	PushFollow(FOLLOW_matrixmultiplication_in_assignment182);
            	        	matrixmultiplication10 = matrixmultiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixmultiplication10.Tree);
            	        	 retval.ret.setRhs(((matrixmultiplication10 != null) ? matrixmultiplication10.ret : null)); 

            	        }
            	        break;

            	}

            	SEMI11=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_assignment192); 
            		SEMI11_tree = (object)adaptor.Create(SEMI11);
            		adaptor.AddChild(root_0, SEMI11_tree);


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
    // Interp.g:55:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable12 = null;

        InterpParser.int_literal_return int_literal13 = null;



        try 
    	{
            // Interp.g:56:3: ( ( variable | int_literal ) )
            // Interp.g:56:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:56:6: ( variable | int_literal )
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
            	        // Interp.g:56:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal208);
            	        	variable12 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable12.Tree);
            	        	 retval.ret = ((variable12 != null) ? variable12.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:57:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal219);
            	        	int_literal13 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal13.Tree);
            	        	retval.ret = ((int_literal13 != null) ? int_literal13.ret : null); 

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
    // Interp.g:59:1: matrix returns [MatrixElement ret] : '[' e1= row ( '|' e2= row )* ']' ;
    public InterpParser.matrix_return matrix() // throws RecognitionException [1]
    {   
        InterpParser.matrix_return retval = new InterpParser.matrix_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal14 = null;
        IToken char_literal15 = null;
        IToken char_literal16 = null;
        InterpParser.row_return e1 = null;

        InterpParser.row_return e2 = null;


        object char_literal14_tree=null;
        object char_literal15_tree=null;
        object char_literal16_tree=null;


          retval.ret = new MatrixElement();

        try 
    	{
            // Interp.g:63:3: ( '[' e1= row ( '|' e2= row )* ']' )
            // Interp.g:63:5: '[' e1= row ( '|' e2= row )* ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal14=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_matrix244); 
            		char_literal14_tree = (object)adaptor.Create(char_literal14);
            		adaptor.AddChild(root_0, char_literal14_tree);

            	PushFollow(FOLLOW_row_in_matrix248);
            	e1 = row();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e1.Tree);
            	 retval.ret.addRows(((e1 != null) ? e1.ret : null)); 
            	// Interp.g:64:5: ( '|' e2= row )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == SEP) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // Interp.g:64:6: '|' e2= row
            			    {
            			    	char_literal15=(IToken)Match(input,SEP,FOLLOW_SEP_in_matrix257); 
            			    		char_literal15_tree = (object)adaptor.Create(char_literal15);
            			    		adaptor.AddChild(root_0, char_literal15_tree);

            			    	PushFollow(FOLLOW_row_in_matrix261);
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

            	char_literal16=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_matrix271); 
            		char_literal16_tree = (object)adaptor.Create(char_literal16);
            		adaptor.AddChild(root_0, char_literal16_tree);


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

    public class scalar_return : ParserRuleReturnScope
    {
        public ScalarElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scalar"
    // Interp.g:68:1: scalar returns [ScalarElement ret] : '[' e1= row ']' ;
    public InterpParser.scalar_return scalar() // throws RecognitionException [1]
    {   
        InterpParser.scalar_return retval = new InterpParser.scalar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal17 = null;
        IToken char_literal18 = null;
        InterpParser.row_return e1 = null;


        object char_literal17_tree=null;
        object char_literal18_tree=null;


          retval.ret = new ScalarElement();

        try 
    	{
            // Interp.g:72:3: ( '[' e1= row ']' )
            // Interp.g:72:5: '[' e1= row ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_scalar294); 
            		char_literal17_tree = (object)adaptor.Create(char_literal17);
            		adaptor.AddChild(root_0, char_literal17_tree);

            	PushFollow(FOLLOW_row_in_scalar298);
            	e1 = row();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e1.Tree);
            	 retval.ret.addRow(((e1 != null) ? e1.ret : null)); 
            	char_literal18=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_scalar302); 
            		char_literal18_tree = (object)adaptor.Create(char_literal18);
            		adaptor.AddChild(root_0, char_literal18_tree);


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
    // $ANTLR end "scalar"

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
    // Interp.g:75:1: row returns [RowElement ret] : s= int_literal ( ',' t= int_literal )* ;
    public InterpParser.row_return row() // throws RecognitionException [1]
    {   
        InterpParser.row_return retval = new InterpParser.row_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal19 = null;
        InterpParser.int_literal_return s = null;

        InterpParser.int_literal_return t = null;


        object char_literal19_tree=null;


          retval.ret = new RowElement();

        try 
    	{
            // Interp.g:79:3: (s= int_literal ( ',' t= int_literal )* )
            // Interp.g:79:5: s= int_literal ( ',' t= int_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_int_literal_in_row328);
            	s = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, s.Tree);
            	 retval.ret.addElement(((s != null) ? s.ret : null)); 
            	// Interp.g:80:5: ( ',' t= int_literal )*
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
            			    // Interp.g:80:7: ',' t= int_literal
            			    {
            			    	char_literal19=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_row338); 
            			    		char_literal19_tree = (object)adaptor.Create(char_literal19);
            			    		adaptor.AddChild(root_0, char_literal19_tree);

            			    	PushFollow(FOLLOW_int_literal_in_row342);
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
    // Interp.g:83:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE20 = null;

        object VARIABLE20_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:87:3: ( VARIABLE )
            // Interp.g:87:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE20=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable371); 
            		VARIABLE20_tree = (object)adaptor.Create(VARIABLE20);
            		adaptor.AddChild(root_0, VARIABLE20_tree);

            	 retval.ret.setText(((VARIABLE20 != null) ? VARIABLE20.Text : null)); 

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
    // Interp.g:89:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL21 = null;

        object INT_LITERAL21_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:93:3: ( INT_LITERAL )
            // Interp.g:93:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL21=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal392); 
            		INT_LITERAL21_tree = (object)adaptor.Create(INT_LITERAL21);
            		adaptor.AddChild(root_0, INT_LITERAL21_tree);

            	 retval.ret.setText(((INT_LITERAL21 != null) ? INT_LITERAL21.Text : null)); 

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
    // Interp.g:95:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal22 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal22_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:99:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:99:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition415);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal22=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition424); 
            		char_literal22_tree = (object)adaptor.Create(char_literal22);
            		adaptor.AddChild(root_0, char_literal22_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition433);
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

    public class matrixaddition_return : ParserRuleReturnScope
    {
        public MatrixAdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixaddition"
    // Interp.g:103:1: matrixaddition returns [MatrixAdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.matrixaddition_return matrixaddition() // throws RecognitionException [1]
    {   
        InterpParser.matrixaddition_return retval = new InterpParser.matrixaddition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal23 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal23_tree=null;


          retval.ret = new MatrixAdditionOperationElement();

        try 
    	{
            // Interp.g:107:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:107:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_matrixaddition456);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal23=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_matrixaddition465); 
            		char_literal23_tree = (object)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_matrixaddition474);
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
    // $ANTLR end "matrixaddition"

    public class matrixmultiplication_return : ParserRuleReturnScope
    {
        public MatrixMultiplicationOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixmultiplication"
    // Interp.g:111:1: matrixmultiplication returns [MatrixMultiplicationOperationElement ret] : el1= var_or_int_literal '*' el2= var_or_int_literal ;
    public InterpParser.matrixmultiplication_return matrixmultiplication() // throws RecognitionException [1]
    {   
        InterpParser.matrixmultiplication_return retval = new InterpParser.matrixmultiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal24 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal24_tree=null;


          retval.ret = new MatrixMultiplicationOperationElement();

        try 
    	{
            // Interp.g:115:3: (el1= var_or_int_literal '*' el2= var_or_int_literal )
            // Interp.g:115:5: el1= var_or_int_literal '*' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_matrixmultiplication501);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal24=(IToken)Match(input,MUL,FOLLOW_MUL_in_matrixmultiplication510); 
            		char_literal24_tree = (object)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_matrixmultiplication519);
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
    // $ANTLR end "matrixmultiplication"

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
    // Interp.g:119:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal SEMI ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal25 = null;
        IToken SEMI27 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal26 = null;


        object string_literal25_tree=null;
        object SEMI27_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:123:3: ( 'print' var_or_int_literal SEMI )
            // Interp.g:123:5: 'print' var_or_int_literal SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal25=(IToken)Match(input,19,FOLLOW_19_in_print540); 
            		string_literal25_tree = (object)adaptor.Create(string_literal25);
            		adaptor.AddChild(root_0, string_literal25_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print542);
            	var_or_int_literal26 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal26.Tree);
            	retval.ret.setChildElement(((var_or_int_literal26 != null) ? var_or_int_literal26.ret : null)); 
            	SEMI27=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_print546); 
            		SEMI27_tree = (object)adaptor.Create(SEMI27);
            		adaptor.AddChild(root_0, SEMI27_tree);


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

    public class parallel_for_return : ParserRuleReturnScope
    {
        public ParallelForOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallel_for"
    // Interp.g:132:1: parallel_for returns [ParallelForOperationElement ret] : 'parallel-for' '(' variable ASSIGNMENT low= int_literal '..' high= int_literal ')' '{' ( parallelassignment )* '}' SEMI ;
    public InterpParser.parallel_for_return parallel_for() // throws RecognitionException [1]
    {   
        InterpParser.parallel_for_return retval = new InterpParser.parallel_for_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal28 = null;
        IToken char_literal29 = null;
        IToken ASSIGNMENT31 = null;
        IToken string_literal32 = null;
        IToken char_literal33 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        IToken SEMI37 = null;
        InterpParser.int_literal_return low = null;

        InterpParser.int_literal_return high = null;

        InterpParser.variable_return variable30 = null;

        InterpParser.parallelassignment_return parallelassignment35 = null;


        object string_literal28_tree=null;
        object char_literal29_tree=null;
        object ASSIGNMENT31_tree=null;
        object string_literal32_tree=null;
        object char_literal33_tree=null;
        object char_literal34_tree=null;
        object char_literal36_tree=null;
        object SEMI37_tree=null;


          retval.ret = new ParallelForOperationElement();

        try 
    	{
            // Interp.g:136:3: ( 'parallel-for' '(' variable ASSIGNMENT low= int_literal '..' high= int_literal ')' '{' ( parallelassignment )* '}' SEMI )
            // Interp.g:136:5: 'parallel-for' '(' variable ASSIGNMENT low= int_literal '..' high= int_literal ')' '{' ( parallelassignment )* '}' SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal28=(IToken)Match(input,20,FOLLOW_20_in_parallel_for575); 
            		string_literal28_tree = (object)adaptor.Create(string_literal28);
            		adaptor.AddChild(root_0, string_literal28_tree);

            	char_literal29=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_parallel_for577); 
            		char_literal29_tree = (object)adaptor.Create(char_literal29);
            		adaptor.AddChild(root_0, char_literal29_tree);

            	PushFollow(FOLLOW_variable_in_parallel_for579);
            	variable30 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable30.Tree);
            	ASSIGNMENT31=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_parallel_for581); 
            		ASSIGNMENT31_tree = (object)adaptor.Create(ASSIGNMENT31);
            		adaptor.AddChild(root_0, ASSIGNMENT31_tree);

            	PushFollow(FOLLOW_int_literal_in_parallel_for585);
            	low = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, low.Tree);
            	string_literal32=(IToken)Match(input,21,FOLLOW_21_in_parallel_for587); 
            		string_literal32_tree = (object)adaptor.Create(string_literal32);
            		adaptor.AddChild(root_0, string_literal32_tree);

            	PushFollow(FOLLOW_int_literal_in_parallel_for591);
            	high = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, high.Tree);
            	char_literal33=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_parallel_for593); 
            		char_literal33_tree = (object)adaptor.Create(char_literal33);
            		adaptor.AddChild(root_0, char_literal33_tree);

            	char_literal34=(IToken)Match(input,22,FOLLOW_22_in_parallel_for595); 
            		char_literal34_tree = (object)adaptor.Create(char_literal34);
            		adaptor.AddChild(root_0, char_literal34_tree);

            	// Interp.g:136:90: ( parallelassignment )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == VARIABLE) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // Interp.g:136:91: parallelassignment
            			    {
            			    	PushFollow(FOLLOW_parallelassignment_in_parallel_for598);
            			    	parallelassignment35 = parallelassignment();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, parallelassignment35.Tree);
            			    	retval.ret.addExpression(((parallelassignment35 != null) ? parallelassignment35.ret : null)); 

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	char_literal36=(IToken)Match(input,23,FOLLOW_23_in_parallel_for605); 
            		char_literal36_tree = (object)adaptor.Create(char_literal36);
            		adaptor.AddChild(root_0, char_literal36_tree);

            	SEMI37=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_parallel_for607); 
            		SEMI37_tree = (object)adaptor.Create(SEMI37);
            		adaptor.AddChild(root_0, SEMI37_tree);

            	 retval.ret.setChildElement(((variable30 != null) ? variable30.ret : null)); retval.ret.setLowRange(((low != null) ? low.ret : null)); retval.ret.setHighRange(((high != null) ? high.ret : null)); 

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
    // $ANTLR end "parallel_for"

    public class parallelassignment_return : ParserRuleReturnScope
    {
        public ParallelAssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallelassignment"
    // Interp.g:140:1: parallelassignment returns [ParallelAssignmentOperationElement ret] : vectorindex ASSIGNMENT ( var_or_int_literal | paralleladdition ) SEMI ;
    public InterpParser.parallelassignment_return parallelassignment() // throws RecognitionException [1]
    {   
        InterpParser.parallelassignment_return retval = new InterpParser.parallelassignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT39 = null;
        IToken SEMI42 = null;
        InterpParser.vectorindex_return vectorindex38 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal40 = null;

        InterpParser.paralleladdition_return paralleladdition41 = null;


        object ASSIGNMENT39_tree=null;
        object SEMI42_tree=null;


          retval.ret = new ParallelAssignmentOperationElement();

        try 
    	{
            // Interp.g:144:3: ( vectorindex ASSIGNMENT ( var_or_int_literal | paralleladdition ) SEMI )
            // Interp.g:144:5: vectorindex ASSIGNMENT ( var_or_int_literal | paralleladdition ) SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_vectorindex_in_parallelassignment633);
            	vectorindex38 = vectorindex();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, vectorindex38.Tree);
            	retval.ret.setLhs(((vectorindex38 != null) ? vectorindex38.ret : null)); 
            	ASSIGNMENT39=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_parallelassignment641); 
            		ASSIGNMENT39_tree = (object)adaptor.Create(ASSIGNMENT39);
            		adaptor.AddChild(root_0, ASSIGNMENT39_tree);

            	// Interp.g:146:5: ( var_or_int_literal | paralleladdition )
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == VARIABLE) )
            	{
            	    int LA8_1 = input.LA(2);

            	    if ( (LA8_1 == LBRACK || LA8_1 == PLUS) )
            	    {
            	        alt8 = 2;
            	    }
            	    else if ( (LA8_1 == SEMI) )
            	    {
            	        alt8 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d8s1 =
            	            new NoViableAltException("", 8, 1, input);

            	        throw nvae_d8s1;
            	    }
            	}
            	else if ( (LA8_0 == INT_LITERAL) )
            	{
            	    int LA8_2 = input.LA(2);

            	    if ( (LA8_2 == PLUS) )
            	    {
            	        alt8 = 2;
            	    }
            	    else if ( (LA8_2 == SEMI) )
            	    {
            	        alt8 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d8s2 =
            	            new NoViableAltException("", 8, 2, input);

            	        throw nvae_d8s2;
            	    }
            	}
            	else 
            	{
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // Interp.g:146:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_parallelassignment649);
            	        	var_or_int_literal40 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal40.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal40 != null) ? var_or_int_literal40.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:147:7: paralleladdition
            	        {
            	        	PushFollow(FOLLOW_paralleladdition_in_parallelassignment660);
            	        	paralleladdition41 = paralleladdition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, paralleladdition41.Tree);
            	        	retval.ret.setRhs(((paralleladdition41 != null) ? paralleladdition41.ret : null)); 

            	        }
            	        break;

            	}

            	SEMI42=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_parallelassignment670); 
            		SEMI42_tree = (object)adaptor.Create(SEMI42);
            		adaptor.AddChild(root_0, SEMI42_tree);


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
    // $ANTLR end "parallelassignment"

    public class paralleladdition_return : ParserRuleReturnScope
    {
        public ParallelAdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "paralleladdition"
    // Interp.g:150:1: paralleladdition returns [ParallelAdditionOperationElement ret] : (el1= vectorindex '+' el2= vectorindex | el3= vectorindex '+' el4= var_or_int_literal | el5= var_or_int_literal '+' el6= vectorindex );
    public InterpParser.paralleladdition_return paralleladdition() // throws RecognitionException [1]
    {   
        InterpParser.paralleladdition_return retval = new InterpParser.paralleladdition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal43 = null;
        IToken char_literal44 = null;
        IToken char_literal45 = null;
        InterpParser.vectorindex_return el1 = null;

        InterpParser.vectorindex_return el2 = null;

        InterpParser.vectorindex_return el3 = null;

        InterpParser.var_or_int_literal_return el4 = null;

        InterpParser.var_or_int_literal_return el5 = null;

        InterpParser.vectorindex_return el6 = null;


        object char_literal43_tree=null;
        object char_literal44_tree=null;
        object char_literal45_tree=null;


          retval.ret = new ParallelAdditionOperationElement();

        try 
    	{
            // Interp.g:154:3: (el1= vectorindex '+' el2= vectorindex | el3= vectorindex '+' el4= var_or_int_literal | el5= var_or_int_literal '+' el6= vectorindex )
            int alt9 = 3;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // Interp.g:154:5: el1= vectorindex '+' el2= vectorindex
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorindex_in_paralleladdition691);
                    	el1 = vectorindex();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, el1.Tree);
                    	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
                    	char_literal43=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_paralleladdition700); 
                    		char_literal43_tree = (object)adaptor.Create(char_literal43);
                    		adaptor.AddChild(root_0, char_literal43_tree);

                    	PushFollow(FOLLOW_vectorindex_in_paralleladdition709);
                    	el2 = vectorindex();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, el2.Tree);
                    	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

                    }
                    break;
                case 2 :
                    // Interp.g:158:5: el3= vectorindex '+' el4= var_or_int_literal
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorindex_in_paralleladdition726);
                    	el3 = vectorindex();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, el3.Tree);
                    	 retval.ret.setLhs(((el3 != null) ? el3.ret : null)); 
                    	char_literal44=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_paralleladdition734); 
                    		char_literal44_tree = (object)adaptor.Create(char_literal44);
                    		adaptor.AddChild(root_0, char_literal44_tree);

                    	PushFollow(FOLLOW_var_or_int_literal_in_paralleladdition742);
                    	el4 = var_or_int_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, el4.Tree);
                    	 retval.ret.setRhs(((el4 != null) ? el4.ret : null)); 

                    }
                    break;
                case 3 :
                    // Interp.g:162:5: el5= var_or_int_literal '+' el6= vectorindex
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_var_or_int_literal_in_paralleladdition759);
                    	el5 = var_or_int_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, el5.Tree);
                    	 retval.ret.setLhs(((el5 != null) ? el5.ret : null)); 
                    	char_literal45=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_paralleladdition767); 
                    		char_literal45_tree = (object)adaptor.Create(char_literal45);
                    		adaptor.AddChild(root_0, char_literal45_tree);

                    	PushFollow(FOLLOW_vectorindex_in_paralleladdition775);
                    	el6 = vectorindex();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, el6.Tree);
                    	 retval.ret.setRhs(((el6 != null) ? el6.ret : null)); 

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
    // $ANTLR end "paralleladdition"

    public class vectorindex_return : ParserRuleReturnScope
    {
        public VectorIndexElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorindex"
    // Interp.g:167:1: vectorindex returns [VectorIndexElement ret] : ( variable '[' var_or_int_literal ']' | variable '[' v1= var_or_int_literal ']' '[' v2= var_or_int_literal ']' );
    public InterpParser.vectorindex_return vectorindex() // throws RecognitionException [1]
    {   
        InterpParser.vectorindex_return retval = new InterpParser.vectorindex_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        IToken char_literal49 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken char_literal53 = null;
        IToken char_literal54 = null;
        InterpParser.var_or_int_literal_return v1 = null;

        InterpParser.var_or_int_literal_return v2 = null;

        InterpParser.variable_return variable46 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal48 = null;

        InterpParser.variable_return variable50 = null;


        object char_literal47_tree=null;
        object char_literal49_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object char_literal53_tree=null;
        object char_literal54_tree=null;


          retval.ret = new VectorIndexElement();

        try 
    	{
            // Interp.g:171:3: ( variable '[' var_or_int_literal ']' | variable '[' v1= var_or_int_literal ']' '[' v2= var_or_int_literal ']' )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == VARIABLE) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == LBRACK) )
                {
                    int LA10_2 = input.LA(3);

                    if ( (LA10_2 == VARIABLE) )
                    {
                        int LA10_3 = input.LA(4);

                        if ( (LA10_3 == RBRACK) )
                        {
                            int LA10_5 = input.LA(5);

                            if ( (LA10_5 == LBRACK) )
                            {
                                alt10 = 2;
                            }
                            else if ( ((LA10_5 >= ASSIGNMENT && LA10_5 <= SEMI) || LA10_5 == PLUS) )
                            {
                                alt10 = 1;
                            }
                            else 
                            {
                                NoViableAltException nvae_d10s5 =
                                    new NoViableAltException("", 10, 5, input);

                                throw nvae_d10s5;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d10s3 =
                                new NoViableAltException("", 10, 3, input);

                            throw nvae_d10s3;
                        }
                    }
                    else if ( (LA10_2 == INT_LITERAL) )
                    {
                        int LA10_4 = input.LA(4);

                        if ( (LA10_4 == RBRACK) )
                        {
                            int LA10_5 = input.LA(5);

                            if ( (LA10_5 == LBRACK) )
                            {
                                alt10 = 2;
                            }
                            else if ( ((LA10_5 >= ASSIGNMENT && LA10_5 <= SEMI) || LA10_5 == PLUS) )
                            {
                                alt10 = 1;
                            }
                            else 
                            {
                                NoViableAltException nvae_d10s5 =
                                    new NoViableAltException("", 10, 5, input);

                                throw nvae_d10s5;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d10s4 =
                                new NoViableAltException("", 10, 4, input);

                            throw nvae_d10s4;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d10s2 =
                            new NoViableAltException("", 10, 2, input);

                        throw nvae_d10s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // Interp.g:171:5: variable '[' var_or_int_literal ']'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_vectorindex801);
                    	variable46 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable46.Tree);
                    	char_literal47=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_vectorindex803); 
                    		char_literal47_tree = (object)adaptor.Create(char_literal47);
                    		adaptor.AddChild(root_0, char_literal47_tree);

                    	PushFollow(FOLLOW_var_or_int_literal_in_vectorindex805);
                    	var_or_int_literal48 = var_or_int_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, var_or_int_literal48.Tree);
                    	char_literal49=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_vectorindex807); 
                    		char_literal49_tree = (object)adaptor.Create(char_literal49);
                    		adaptor.AddChild(root_0, char_literal49_tree);

                    	 retval.ret.setVariableElement(((variable46 != null) ? variable46.ret : null)); retval.ret.setFirstIndexElement(((var_or_int_literal48 != null) ? var_or_int_literal48.ret : null)); 

                    }
                    break;
                case 2 :
                    // Interp.g:172:5: variable '[' v1= var_or_int_literal ']' '[' v2= var_or_int_literal ']'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_vectorindex815);
                    	variable50 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable50.Tree);
                    	char_literal51=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_vectorindex817); 
                    		char_literal51_tree = (object)adaptor.Create(char_literal51);
                    		adaptor.AddChild(root_0, char_literal51_tree);

                    	PushFollow(FOLLOW_var_or_int_literal_in_vectorindex821);
                    	v1 = var_or_int_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, v1.Tree);
                    	char_literal52=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_vectorindex823); 
                    		char_literal52_tree = (object)adaptor.Create(char_literal52);
                    		adaptor.AddChild(root_0, char_literal52_tree);

                    	char_literal53=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_vectorindex825); 
                    		char_literal53_tree = (object)adaptor.Create(char_literal53);
                    		adaptor.AddChild(root_0, char_literal53_tree);

                    	PushFollow(FOLLOW_var_or_int_literal_in_vectorindex829);
                    	v2 = var_or_int_literal();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, v2.Tree);
                    	char_literal54=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_vectorindex831); 
                    		char_literal54_tree = (object)adaptor.Create(char_literal54);
                    		adaptor.AddChild(root_0, char_literal54_tree);

                    	 retval.ret.setVariableElement(((variable50 != null) ? variable50.ret : null)); retval.ret.setFirstIndexElement(((v1 != null) ? v1.ret : null)); retval.ret.setSecondIndexElement(((v2 != null) ? v2.ret : null)); 

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
    // $ANTLR end "vectorindex"

    // Delegated rules


   	protected DFA9 dfa9;
	private void InitializeCyclicDFAs()
	{
    	this.dfa9 = new DFA9(this);
	}

    const string DFA9_eotS =
        "\x0f\uffff";
    const string DFA9_eofS =
        "\x0f\uffff";
    const string DFA9_minS =
        "\x01\x06\x01\x0b\x01\uffff\x01\x06\x02\x0c\x01\x0b\x02\x06\x02"+
        "\x0c\x01\x05\x01\uffff\x01\x0f\x01\uffff";
    const string DFA9_maxS =
        "\x01\x07\x01\x0f\x01\uffff\x01\x07\x02\x0c\x01\x0f\x02\x07\x02"+
        "\x0c\x01\x0b\x01\uffff\x01\x0f\x01\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x03\x09\uffff\x01\x02\x01\uffff\x01\x01";
    const string DFA9_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x01\x01\x02",
            "\x01\x03\x03\uffff\x01\x02",
            "",
            "\x01\x04\x01\x05",
            "\x01\x06",
            "\x01\x06",
            "\x01\x07\x03\uffff\x01\x08",
            "\x01\x09\x01\x0a",
            "\x01\x0b\x01\x0c",
            "\x01\x0d",
            "\x01\x0d",
            "\x01\x0c\x05\uffff\x01\x0e",
            "",
            "\x01\x08",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "150:1: paralleladdition returns [ParallelAdditionOperationElement ret] : (el1= vectorindex '+' el2= vectorindex | el3= vectorindex '+' el4= var_or_int_literal | el5= var_or_int_literal '+' el6= vectorindex );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000180042UL});
    public static readonly BitSet FOLLOW_assignment_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallel_for_in_expr109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment134 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment142 = new BitSet(new ulong[]{0x00000000000008C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment150 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_matrix_in_assignment162 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_matrixaddition_in_assignment172 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_matrixmultiplication_in_assignment182 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMI_in_assignment192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_matrix244 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_matrix248 = new BitSet(new ulong[]{0x0000000000005000UL});
    public static readonly BitSet FOLLOW_SEP_in_matrix257 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_matrix261 = new BitSet(new ulong[]{0x0000000000005000UL});
    public static readonly BitSet FOLLOW_RBRACK_in_matrix271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_scalar294 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_row_in_scalar298 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RBRACK_in_scalar302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_row328 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_COMMA_in_row338 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_row342 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition415 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition424 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_matrixaddition456 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_matrixaddition465 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_matrixaddition474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_matrixmultiplication501 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_MUL_in_matrixmultiplication510 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_matrixmultiplication519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_print540 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print542 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMI_in_print546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_parallel_for575 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_parallel_for577 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_variable_in_parallel_for579 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_parallel_for581 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallel_for585 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_parallel_for587 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallel_for591 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_parallel_for593 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_parallel_for595 = new BitSet(new ulong[]{0x0000000000800040UL});
    public static readonly BitSet FOLLOW_parallelassignment_in_parallel_for598 = new BitSet(new ulong[]{0x0000000000800040UL});
    public static readonly BitSet FOLLOW_23_in_parallel_for605 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMI_in_parallel_for607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorindex_in_parallelassignment633 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_parallelassignment641 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_parallelassignment649 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_paralleladdition_in_parallelassignment660 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_SEMI_in_parallelassignment670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorindex_in_paralleladdition691 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_paralleladdition700 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_vectorindex_in_paralleladdition709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorindex_in_paralleladdition726 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_paralleladdition734 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_paralleladdition742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_paralleladdition759 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_PLUS_in_paralleladdition767 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_vectorindex_in_paralleladdition775 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorindex801 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LBRACK_in_vectorindex803 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_vectorindex805 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RBRACK_in_vectorindex807 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorindex815 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LBRACK_in_vectorindex817 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_vectorindex821 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RBRACK_in_vectorindex823 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LBRACK_in_vectorindex825 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_vectorindex829 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RBRACK_in_vectorindex831 = new BitSet(new ulong[]{0x0000000000000002UL});

}

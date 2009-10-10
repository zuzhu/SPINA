// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-09 21:14:49


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
    public const int RBRACK = 12;
    public const int RPAREN = 9;
    public const int INT_LITERAL = 7;
    public const int LBRACK = 11;
    public const int VARIABLE = 6;
    public const int T__18 = 18;
    public const int COMMA = 10;
    public const int WHITESPACE = 17;
    public const int PLUS = 14;
    public const int ASSIGNMENT = 4;
    public const int MINUS = 15;
    public const int DOT = 13;
    public const int EOF = -1;
    public const int SEMI = 5;
    public const int MUL = 16;
    public const int LPAREN = 8;

    // delegates
    // delegators

    public InterpLexer() 
    {
		InitializeCyclicDFAs();
    }
    public InterpLexer(ICharStream input)
		: this(input, null) {
    }
    public InterpLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Interp.g";} 
    }

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( 'print' )
            // Interp.g:11:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "LPAREN"
    public void mLPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:111:8: ( '(' )
            // Interp.g:111:10: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LPAREN"

    // $ANTLR start "RPAREN"
    public void mRPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:112:8: ( ')' )
            // Interp.g:112:10: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RPAREN"

    // $ANTLR start "COMMA"
    public void mCOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:113:7: ( ',' )
            // Interp.g:113:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMA"

    // $ANTLR start "LBRACK"
    public void mLBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:114:8: ( '[' )
            // Interp.g:114:10: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRACK"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:115:8: ( ']' )
            // Interp.g:115:10: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRACK"

    // $ANTLR start "SEMI"
    public void mSEMI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:116:6: ( ';' )
            // Interp.g:116:8: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMI"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:117:5: ( '.' )
            // Interp.g:117:7: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:119:5: ( '+' )
            // Interp.g:119:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:120:7: ( '-' )
            // Interp.g:120:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "MUL"
    public void mMUL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MUL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:121:5: ( '*' )
            // Interp.g:121:7: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MUL"

    // $ANTLR start "ASSIGNMENT"
    public void mASSIGNMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:123:11: ( '=' )
            // Interp.g:123:13: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGNMENT"

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:124:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:124:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:124:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


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

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VARIABLE"

    // $ANTLR start "INT_LITERAL"
    public void mINT_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:125:12: ( ( '0' .. '9' )+ )
            // Interp.g:125:14: ( '0' .. '9' )+
            {
            	// Interp.g:125:14: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Interp.g:125:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:126:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:126:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:126:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	_channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    override public void mTokens() // throws RecognitionException 
    {
        // Interp.g:1:8: ( T__18 | LPAREN | RPAREN | COMMA | LBRACK | RBRACK | SEMI | DOT | PLUS | MINUS | MUL | ASSIGNMENT | VARIABLE | INT_LITERAL | WHITESPACE )
        int alt4 = 15;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // Interp.g:1:10: T__18
                {
                	mT__18(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: LPAREN
                {
                	mLPAREN(); 

                }
                break;
            case 3 :
                // Interp.g:1:23: RPAREN
                {
                	mRPAREN(); 

                }
                break;
            case 4 :
                // Interp.g:1:30: COMMA
                {
                	mCOMMA(); 

                }
                break;
            case 5 :
                // Interp.g:1:36: LBRACK
                {
                	mLBRACK(); 

                }
                break;
            case 6 :
                // Interp.g:1:43: RBRACK
                {
                	mRBRACK(); 

                }
                break;
            case 7 :
                // Interp.g:1:50: SEMI
                {
                	mSEMI(); 

                }
                break;
            case 8 :
                // Interp.g:1:55: DOT
                {
                	mDOT(); 

                }
                break;
            case 9 :
                // Interp.g:1:59: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 10 :
                // Interp.g:1:64: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 11 :
                // Interp.g:1:70: MUL
                {
                	mMUL(); 

                }
                break;
            case 12 :
                // Interp.g:1:74: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 13 :
                // Interp.g:1:85: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 14 :
                // Interp.g:1:94: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 15 :
                // Interp.g:1:106: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x01\uffff\x01\x0d\x0e\uffff\x03\x0d\x01\x14\x01\uffff";
    const string DFA4_eofS =
        "\x15\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x72\x0e\uffff\x01\x69\x01\x6e\x01\x74\x01\x41\x01"+
        "\uffff";
    const string DFA4_maxS =
        "\x01\x7a\x01\x72\x0e\uffff\x01\x69\x01\x6e\x01\x74\x01\x7a\x01"+
        "\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x04"+
        "\uffff\x01\x01";
    const string DFA4_specialS =
        "\x15\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x0f\x02\uffff\x01\x0f\x12\uffff\x01\x0f\x07\uffff\x01"+
            "\x02\x01\x03\x01\x0b\x01\x09\x01\x04\x01\x0a\x01\x08\x01\uffff"+
            "\x0a\x0e\x01\uffff\x01\x07\x01\uffff\x01\x0c\x03\uffff\x1a\x0d"+
            "\x01\x05\x01\uffff\x01\x06\x03\uffff\x0f\x0d\x01\x01\x0a\x0d",
            "\x01\x10",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x11",
            "\x01\x12",
            "\x01\x13",
            "\x1a\x0d\x06\uffff\x1a\x0d",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__18 | LPAREN | RPAREN | COMMA | LBRACK | RBRACK | SEMI | DOT | PLUS | MINUS | MUL | ASSIGNMENT | VARIABLE | INT_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}

// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-13 10:01:11


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
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

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
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
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:12:7: ( 'parallel-for' )
            // Interp.g:12:9: 'parallel-for'
            {
            	Match("parallel-for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:13:7: ( '..' )
            // Interp.g:13:9: '..'
            {
            	Match(".."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:14:7: ( '{' )
            // Interp.g:14:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:15:7: ( '}' )
            // Interp.g:15:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "LPAREN"
    public void mLPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:199:8: ( '(' )
            // Interp.g:199:10: '('
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
            // Interp.g:200:8: ( ')' )
            // Interp.g:200:10: ')'
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
            // Interp.g:201:7: ( ',' )
            // Interp.g:201:9: ','
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
            // Interp.g:202:8: ( '[' )
            // Interp.g:202:10: '['
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
            // Interp.g:203:8: ( ']' )
            // Interp.g:203:10: ']'
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
            // Interp.g:204:6: ( ';' )
            // Interp.g:204:8: ';'
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
            // Interp.g:205:5: ( '.' )
            // Interp.g:205:7: '.'
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

    // $ANTLR start "SEP"
    public void mSEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:206:5: ( '|' )
            // Interp.g:206:7: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEP"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:208:5: ( '+' )
            // Interp.g:208:7: '+'
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
            // Interp.g:209:7: ( '-' )
            // Interp.g:209:9: '-'
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
            // Interp.g:210:5: ( '*' )
            // Interp.g:210:7: '*'
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
            // Interp.g:212:11: ( '=' )
            // Interp.g:212:13: '='
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
            // Interp.g:213:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:213:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:213:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
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
            // Interp.g:214:12: ( ( '0' .. '9' )+ )
            // Interp.g:214:14: ( '0' .. '9' )+
            {
            	// Interp.g:214:14: ( '0' .. '9' )+
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
            			    // Interp.g:214:15: '0' .. '9'
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
            // Interp.g:215:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:215:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:215:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
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
        // Interp.g:1:8: ( T__19 | T__20 | T__21 | T__22 | T__23 | LPAREN | RPAREN | COMMA | LBRACK | RBRACK | SEMI | DOT | SEP | PLUS | MINUS | MUL | ASSIGNMENT | VARIABLE | INT_LITERAL | WHITESPACE )
        int alt4 = 20;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // Interp.g:1:10: T__19
                {
                	mT__19(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: T__20
                {
                	mT__20(); 

                }
                break;
            case 3 :
                // Interp.g:1:22: T__21
                {
                	mT__21(); 

                }
                break;
            case 4 :
                // Interp.g:1:28: T__22
                {
                	mT__22(); 

                }
                break;
            case 5 :
                // Interp.g:1:34: T__23
                {
                	mT__23(); 

                }
                break;
            case 6 :
                // Interp.g:1:40: LPAREN
                {
                	mLPAREN(); 

                }
                break;
            case 7 :
                // Interp.g:1:47: RPAREN
                {
                	mRPAREN(); 

                }
                break;
            case 8 :
                // Interp.g:1:54: COMMA
                {
                	mCOMMA(); 

                }
                break;
            case 9 :
                // Interp.g:1:60: LBRACK
                {
                	mLBRACK(); 

                }
                break;
            case 10 :
                // Interp.g:1:67: RBRACK
                {
                	mRBRACK(); 

                }
                break;
            case 11 :
                // Interp.g:1:74: SEMI
                {
                	mSEMI(); 

                }
                break;
            case 12 :
                // Interp.g:1:79: DOT
                {
                	mDOT(); 

                }
                break;
            case 13 :
                // Interp.g:1:83: SEP
                {
                	mSEP(); 

                }
                break;
            case 14 :
                // Interp.g:1:87: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 15 :
                // Interp.g:1:92: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 16 :
                // Interp.g:1:98: MUL
                {
                	mMUL(); 

                }
                break;
            case 17 :
                // Interp.g:1:102: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 18 :
                // Interp.g:1:113: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 19 :
                // Interp.g:1:122: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 20 :
                // Interp.g:1:134: WHITESPACE
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
        "\x01\uffff\x01\x10\x01\x16\x10\uffff\x02\x10\x02\uffff\x04\x10"+
        "\x01\x1d\x01\x10\x01\uffff\x03\x10\x01\uffff";
    const string DFA4_eofS =
        "\x22\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x61\x01\x2e\x10\uffff\x01\x69\x01\x72\x02\uffff\x01"+
        "\x6e\x01\x61\x01\x74\x01\x6c\x01\x41\x01\x6c\x01\uffff\x01\x65\x01"+
        "\x6c\x01\x2d\x01\uffff";
    const string DFA4_maxS =
        "\x01\x7d\x01\x72\x01\x2e\x10\uffff\x01\x69\x01\x72\x02\uffff\x01"+
        "\x6e\x01\x61\x01\x74\x01\x6c\x01\x7a\x01\x6c\x01\uffff\x01\x65\x01"+
        "\x6c\x01\x2d\x01\uffff";
    const string DFA4_acceptS =
        "\x03\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01"+
        "\x0a\x01\x0b\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01"+
        "\x13\x01\x14\x02\uffff\x01\x03\x01\x0c\x06\uffff\x01\x01\x03\uffff"+
        "\x01\x02";
    const string DFA4_specialS =
        "\x22\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x12\x02\uffff\x01\x12\x12\uffff\x01\x12\x07\uffff\x01"+
            "\x05\x01\x06\x01\x0e\x01\x0c\x01\x07\x01\x0d\x01\x02\x01\uffff"+
            "\x0a\x11\x01\uffff\x01\x0a\x01\uffff\x01\x0f\x03\uffff\x1a\x10"+
            "\x01\x08\x01\uffff\x01\x09\x03\uffff\x0f\x10\x01\x01\x0a\x10"+
            "\x01\x03\x01\x0b\x01\x04",
            "\x01\x14\x10\uffff\x01\x13",
            "\x01\x15",
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
            "",
            "",
            "\x01\x17",
            "\x01\x18",
            "",
            "",
            "\x01\x19",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "\x1a\x10\x06\uffff\x1a\x10",
            "\x01\x1e",
            "",
            "\x01\x1f",
            "\x01\x20",
            "\x01\x21",
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
            get { return "1:1: Tokens : ( T__19 | T__20 | T__21 | T__22 | T__23 | LPAREN | RPAREN | COMMA | LBRACK | RBRACK | SEMI | DOT | SEP | PLUS | MINUS | MUL | ASSIGNMENT | VARIABLE | INT_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}

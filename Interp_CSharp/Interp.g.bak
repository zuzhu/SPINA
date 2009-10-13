////////////////////////////////////////////////////////////////////////
// Interp.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////

grammar Interp;

options {
  language = 'CSharp';
  output=AST;
} 

@members {
  protected void RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow)
  {
    throw new MismatchedTokenException(ttype, input);
  }
  
  public void RecoverFromMismatchedSet(IIntStream input,
    RecognitionException e, BitSet follow)
  {
    throw e;
  }
}

@rulecatch {
    catch (RecognitionException e) {
        throw e;
    }
}

@parser::header {
using System.Collections.Generic;
}

@lexer::header {
using System.Collections.Generic;
}

/*
 * Parser Rules
 */
program returns [List<Element> ret]
@init {
  retval.ret = new List<Element>();
}
  : (expr {retval.ret.Add($expr.ret); } )+;

expr returns [Element ret]
  : assignment {retval.ret = $assignment.ret;}
  | print { retval.ret = $print.ret; }
  | parallel_for { retval.ret = $parallel_for.ret; }
//  | quit { retval.ret = $quit.ret; }
  ;

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : variable {retval.ret.setLhs($variable.ret); }
    ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); } 
//    | addition {retval.ret.setRhs($addition.ret); }
    | matrix {retval.ret.setRhs($matrix.ret); }
    | matrixaddition {retval.ret.setRhs($matrixaddition.ret); }
    | matrixmultiplication { retval.ret.setRhs($matrixmultiplication.ret); }
    ) SEMI;

var_or_int_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; } );
  
matrix returns [MatrixElement ret]
@init {
  retval.ret = new MatrixElement();
}
  : '[' e1=row { retval.ret.addRows($e1.ret); }
    ('|' e2=row { retval.ret.addRows($e2.ret); retval.ret.Check($e2.ret); })*
    ']' 
  ;

scalar returns [ScalarElement ret]
@init {
  retval.ret = new ScalarElement();
}
  : '[' e1=row { retval.ret.addRow($e1.ret); } ']'
  ;
  
row returns [RowElement ret]
@init {
  retval.ret = new RowElement();
}
  : s=int_literal { retval.ret.addElement($s.ret); }
    ( ',' t=int_literal { retval.ret.addElement($t.ret); } )*
    ;

variable returns [VariableElement ret]
@init {
  retval.ret = new VariableElement();
}
  : VARIABLE { retval.ret.setText($VARIABLE.text); };

int_literal returns [IntegerElement ret]
@init {
  retval.ret = new IntegerElement();
}
  : INT_LITERAL { retval.ret.setText($INT_LITERAL.text); };

addition returns [AdditionOperationElement ret]
@init {
  retval.ret = new AdditionOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };

matrixaddition returns [MatrixAdditionOperationElement ret]
@init {
  retval.ret = new MatrixAdditionOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };
    
matrixmultiplication returns [MatrixMultiplicationOperationElement ret]
@init {
  retval.ret = new MatrixMultiplicationOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '*' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };

print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_or_int_literal {retval.ret.setChildElement($var_or_int_literal.ret); } SEMI
  ; 

//quit returns [QuitOperationElement ret]
//@init {
//  retval.ret = new QuitOperationElement();
//}
//  : 'quit' SEMI {retval.ret.setText(); };

parallel_for returns [ParallelForOperationElement ret]
@init {
  retval.ret = new ParallelForOperationElement();
}
  : 'parallel-for' '(' variable ASSIGNMENT low=int_literal '..' high=int_literal ')' '{' (parallelassignment {retval.ret.addExpression($parallelassignment.ret); } )* '}' SEMI
  { retval.ret.setChildElement($variable.ret); retval.ret.setLowRange($low.ret); retval.ret.setHighRange($high.ret); }
  ;

parallelassignment returns [ParallelAssignmentOperationElement ret]
@init {
  retval.ret = new ParallelAssignmentOperationElement();
}
  : vectorindex {retval.ret.setLhs($vectorindex.ret); }
    ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); } 
    | paralleladdition {retval.ret.setRhs($paralleladdition.ret); }
    ) SEMI;

paralleladdition returns [ParallelAdditionOperationElement ret]
@init {
  retval.ret = new ParallelAdditionOperationElement();
}
  : el1=vectorindex { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=vectorindex { retval.ret.setRhs($el2.ret); }
    | 
    el3=vectorindex { retval.ret.setLhs($el3.ret); }
    '+'
    el4=var_or_int_literal { retval.ret.setRhs($el4.ret); }
    | 
    el5=var_or_int_literal { retval.ret.setLhs($el5.ret); }
    '+'
    el6=vectorindex { retval.ret.setRhs($el6.ret); }
    ;

vectorindex returns [VectorIndexElement ret]
@init {
  retval.ret = new VectorIndexElement();
}
  : variable '[' var_or_int_literal ']' { retval.ret.setVariableElement($variable.ret); retval.ret.setFirstIndexElement($var_or_int_literal.ret); }
  | variable '[' v1=var_or_int_literal ']' '[' v2=var_or_int_literal ']'
  { retval.ret.setVariableElement($variable.ret); retval.ret.setFirstIndexElement($v1.ret); retval.ret.setSecondIndexElement($v2.ret); }
  ;

/*
 * Lexer Rules
 */
 
LPAREN : '(' ;
RPAREN : ')' ;
COMMA : ',' ;
LBRACK : '[' ;
RBRACK : ']' ;
SEMI : ';' ;
DOT : '.' ;
SEP : '|' ;

PLUS: '+';
MINUS : '-';
MUL : '*';

ASSIGNMENT: '=';
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;

//MATRIX : LBRACK ROW (ROWWITHSEMI)* RBRACK;
//ROW : INT_LITERAL (COMMA INT_LITERAL)*;
//ROWWITHSEMI : SEMI ROW;

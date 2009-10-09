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
  | print { retval.ret = $print.ret; };

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : variable {retval.ret.setLhs($variable.ret); }
    ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); } 
    | matrix {retval.ret.setRhs($matrix.ret); }
    | addition {retval.ret.setRhs($addition.ret); }
    ) SEMI;

var_or_int_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; } );
  
matrix returns [MatrixElement ret]
@init {
  retval.ret = new MatrixElement();
}
  : '[' e1=row { retval.ret.addRows($e1.ret); }
    (';' e2=row { retval.ret.addRows($e2.ret); retval.ret.Check($e2.ret); })*
    ']' 
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

print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_or_int_literal {retval.ret.setChildElement($var_or_int_literal.ret); }
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

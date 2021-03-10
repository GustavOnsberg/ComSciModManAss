// This file implements a module where we define a data type "exA"
// to store represent arithmetic expression
module ComSciModManAssTypesAST

// The type for arithmetic expressions
type exA =
  | VarX of string
  | Num of float
  | TimesExpr of (exA * exA)
  | DivExpr of (exA * exA)
  | PlusExpr of (exA * exA)
  | MinusExpr of (exA * exA)
  | PowExpr of (exA * exA)
  | UPlusExpr of (exA)
  | UMinusExpr of (exA)
  | Array of (exA * exA)

// The type for boolean expressions
type exB = 
  | Boo of bool
  | And of (exB * exB)
  | BitAnd of (exB * exB)
  | Or of (exB * exB)
  | BitOr of (exB * exB)
  | Not of (exB)
  | Equal of (exA * exA)
  | NotEqual of (exA * exA)
  | GT of (exA * exA)
  | GTE of (exA * exA)
  | LT of (exA * exA)
  | LTE of (exA * exA)

// The type for command expressions
type exC =
  | Assign of (exC * exA)
  | AssignArray of (exC * exA * exA)
  | Skip
  | Sequence of (exC * exC)

// The type for guarded command expressions
type exGC =
  | Lambda of (exB * exC)
  | Else of (exGC * exGC)
  | IfState of (exGC)
  | DoState of (exGC)

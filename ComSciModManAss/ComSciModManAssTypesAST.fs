// This file implements a module where we define a data type "exA"
// to store represent arithmetic expression
module ComSciModManAssTypesAST

type exA =
  | Num of float
  | TimesExpr of (exA * exA)
  | DivExpr of (exA * exA)
  | PlusExpr of (exA * exA)
  | MinusExpr of (exA * exA)
  | PowExpr of (exA * exA)
  | UPlusExpr of (exA)
  | UMinusExpr of (exA)


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
  
type exC =
  | VarX of string
  | Assign of (exC * exA)
  | AssignArray of (exC * exA * exA)
  | Skip
  | Sequence of (exC * exC)

type exGC =
  | Lambda of (exB * exC)
  | Else of (exGC * exGC)
  | IfState of (exGC)
  | DoState of (exGC)

type ex =
  | NumEx of exA
  | BooEx of exB
  | CommandEx of exC
  | GCommandEx of exGC

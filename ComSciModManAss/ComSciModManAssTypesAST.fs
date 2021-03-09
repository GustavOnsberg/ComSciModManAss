// This file implements a module where we define a data type "exA"
// to store represent arithmetic exAessions
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
  | Or of (exB * exB)
  | Not of (exB)
  | Equal of (exA * exA)
  | NotEqual of (exA * exA)
  | GT of (exA * exA)
  | GTE of (exA * exA)
  | LT of (exA * exA)
  | LTE of (exA * exA)
  | exB of (exB)

type ex =
  |  NumEx of exA
  |  BooEx of exB
  

// This file implements a module where we define a data type "expr"
// to store represent arithmetic expressions
module ComSciModManAssTypesAST

type expr =
  | Num of float
  | TimesExpr of (expr * expr)
  | DivExpr of (expr * expr)
  | PlusExpr of (expr * expr)
  | MinusExpr of (expr * expr)
  | PowExpr of (expr * expr)
  | UPlusExpr of (expr)
  | UMinusExpr of (expr)


type b = 
  | Bool of boolean
  | And of (b * b)
  | Or of (b * b)
  | Not of (b)
  | Equal of (expr * expr)
  | NotEqual of (expr * expr)
  | GT of (expr * expr)
  | GTE of (expr * expr)
  | LT of (expr * expr)
  | LTE of (expr * expr)
  | B of (b)

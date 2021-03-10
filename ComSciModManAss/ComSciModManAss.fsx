#r "C:/Users/frede/.nuget/packages/fslexyacc.runtime/10.0.0/lib/net46/FsLexYacc.Runtime.dll"
open FSharp.Text.Lexing
open System
#load "ComSciModManAssTypesAST.fs"
open ComSciModManAssTypesAST
#load "ComSciModManAssParser.fs"
open ComSciModManAssParser
#load "ComSciModManAssLexer.fs"
open ComSciModManAssLexer

//let rec evalA e =
//  match e with
//    | Num(x) -> x
//    | TimesExpr(x,y) -> evalA(x) * evalA (y)
//    | DivExpr(x,y) -> evalA(x) / evalA (y)
//    | PlusExpr(x,y) -> evalA(x) + evalA (y)
//    | MinusExpr(x,y) -> evalA(x) - evalA (y)
//    | PowExpr(x,y) -> evalA(x) ** evalA (y)
//    | UPlusExpr(x) -> evalA(x)
//    | UMinusExpr(x) -> - evalA(x)
//let rec evalB e =
//    match e with
//    | Boo(x) -> x
//    | And(x,y) -> evalB(x) && evalB(y)
//    | Or(x,y) -> evalB(x) || evalB(y)
//    | Not(x) -> not(evalB(x))
//    | Equal(x,y) -> evalA(x) = evalA(y)
//    | NotEqual(x,y) -> evalA(x) <> evalA(y)
//    | GT(x,y) -> evalA(x) > evalA(y)
//    | GTE(x,y) -> evalA(x) >= evalA(y)
//    | LT(x,y) -> evalA(x) < evalA(y)
//    | LTE(x,y) -> evalA(x) <= evalA(y)
    
//let rec printEval e =
//    match e with
//    | TimesExpr(x,y) -> "(" + printEval(x) + "TIMES" + printEval(y) + ")"
//    | DivExpr(x,y) -> "(" + printEval(x) + "DIV" + printEval(y) + ")"
//    | PlusExpr(x,y) -> "(" + printEval(x) + "PLUS" + printEval (y) + ")"
//    | MinusExpr(x,y) -> "(" + printEval(x) +  "MINUS" + printEval (y) + ")"
//    | PowExpr(x,y) -> "(" + printEval(x) + "POW" + printEval (y) + ")"
//    | UPlusExpr(x) -> "(" + printEval(x) + ")"
//    | UMinusExpr(x) -> "(" + printEval(x) + ")"


let parse input =
    let lexbuf = LexBuffer<char>.FromString input
    ComSciModManAssParser.start ComSciModManAssLexer.tokenize lexbuf
    
let rec compute n =
    if n = 0 then
        printfn "Bye bye"
    else
        printf "Enter GC code: "
        try
        let e = parse (Console.ReadLine())
        printfn "Result: %s" (string(e))
        compute n
        with err -> compute (n-1)
compute 3

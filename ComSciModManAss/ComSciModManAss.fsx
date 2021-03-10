#r "C:/Users/frede/.nuget/packages/fslexyacc.runtime/10.0.0/lib/net46/FsLexYacc.Runtime.dll"
open FSharp.Text.Lexing
open System
#load "ComSciModManAssTypesAST.fs"
open ComSciModManAssTypesAST
#load "ComSciModManAssParser.fs"
open ComSciModManAssParser
#load "ComSciModManAssLexer.fs"
open ComSciModManAssLexer

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

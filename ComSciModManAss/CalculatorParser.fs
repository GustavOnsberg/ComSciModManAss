// Implementation file for parser generated by fsyacc
module CalculatorParser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open FSharp.Text.Lexing
open FSharp.Text.Parsing.ParseHelpers
# 2 "CalculatorParser.fsp"

open CalculatorTypesAST

# 10 "CalculatorParser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | TIMES
  | DIV
  | PLUS
  | MINUS
  | POW
  | LPAR
  | RPAR
  | EOF
  | NUM of (float)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_POW
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_EOF
    | TOKEN_NUM
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_expression

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | TIMES  -> 0 
  | DIV  -> 1 
  | PLUS  -> 2 
  | MINUS  -> 3 
  | POW  -> 4 
  | LPAR  -> 5 
  | RPAR  -> 6 
  | EOF  -> 7 
  | NUM _ -> 8 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_TIMES 
  | 1 -> TOKEN_DIV 
  | 2 -> TOKEN_PLUS 
  | 3 -> TOKEN_MINUS 
  | 4 -> TOKEN_POW 
  | 5 -> TOKEN_LPAR 
  | 6 -> TOKEN_RPAR 
  | 7 -> TOKEN_EOF 
  | 8 -> TOKEN_NUM 
  | 11 -> TOKEN_end_of_input
  | 9 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_expression 
    | 3 -> NONTERM_expression 
    | 4 -> NONTERM_expression 
    | 5 -> NONTERM_expression 
    | 6 -> NONTERM_expression 
    | 7 -> NONTERM_expression 
    | 8 -> NONTERM_expression 
    | 9 -> NONTERM_expression 
    | 10 -> NONTERM_expression 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 11 
let _fsyacc_tagOfErrorTerminal = 9

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | TIMES  -> "TIMES" 
  | DIV  -> "DIV" 
  | PLUS  -> "PLUS" 
  | MINUS  -> "MINUS" 
  | POW  -> "POW" 
  | LPAR  -> "LPAR" 
  | RPAR  -> "RPAR" 
  | EOF  -> "EOF" 
  | NUM _ -> "NUM" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | TIMES  -> (null : System.Object) 
  | DIV  -> (null : System.Object) 
  | PLUS  -> (null : System.Object) 
  | MINUS  -> (null : System.Object) 
  | POW  -> (null : System.Object) 
  | LPAR  -> (null : System.Object) 
  | RPAR  -> (null : System.Object) 
  | EOF  -> (null : System.Object) 
  | NUM _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; 9us; 65535us; 0us; 2us; 12us; 4us; 13us; 5us; 14us; 6us; 15us; 7us; 16us; 8us; 17us; 9us; 18us; 10us; 20us; 11us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; 3us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 6us; 1us; 2us; 3us; 4us; 5us; 6us; 1us; 1us; 6us; 2us; 2us; 3us; 4us; 5us; 6us; 6us; 2us; 3us; 3us; 4us; 5us; 6us; 6us; 2us; 3us; 4us; 4us; 5us; 6us; 6us; 2us; 3us; 4us; 5us; 5us; 6us; 6us; 2us; 3us; 4us; 5us; 6us; 6us; 6us; 2us; 3us; 4us; 5us; 6us; 7us; 6us; 2us; 3us; 4us; 5us; 6us; 8us; 6us; 2us; 3us; 4us; 5us; 6us; 10us; 1us; 2us; 1us; 3us; 1us; 4us; 1us; 5us; 1us; 6us; 1us; 7us; 1us; 8us; 1us; 9us; 1us; 10us; 1us; 10us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; 11us; 13us; 20us; 27us; 34us; 41us; 48us; 55us; 62us; 69us; 71us; 73us; 75us; 77us; 79us; 81us; 83us; 85us; 87us; |]
let _fsyacc_action_rows = 22
let _fsyacc_actionTableElements = [|4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 0us; 49152us; 6us; 32768us; 0us; 12us; 1us; 13us; 2us; 14us; 3us; 15us; 4us; 16us; 7us; 3us; 0us; 16385us; 1us; 16386us; 4us; 16us; 1us; 16387us; 4us; 16us; 3us; 16388us; 0us; 12us; 1us; 13us; 4us; 16us; 3us; 16389us; 0us; 12us; 1us; 13us; 4us; 16us; 1us; 16390us; 4us; 16us; 3us; 16391us; 0us; 12us; 1us; 13us; 4us; 16us; 3us; 16392us; 0us; 12us; 1us; 13us; 4us; 16us; 6us; 32768us; 0us; 12us; 1us; 13us; 2us; 14us; 3us; 15us; 4us; 16us; 6us; 21us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 0us; 16393us; 4us; 32768us; 2us; 17us; 3us; 18us; 5us; 20us; 8us; 19us; 0us; 16394us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 5us; 6us; 13us; 14us; 16us; 18us; 22us; 26us; 28us; 32us; 36us; 43us; 48us; 53us; 58us; 63us; 68us; 73us; 78us; 79us; 84us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 2us; 3us; 3us; 3us; 3us; 3us; 2us; 2us; 1us; 3us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; 2us; 2us; 2us; 2us; 2us; 2us; 2us; 2us; 2us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 65535us; 16385us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 16393us; 65535us; 16394us; |]
let _fsyacc_reductions ()  =    [| 
# 125 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : '_startstart));
# 134 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 32 "CalculatorParser.fsp"
                                                         _1 
                   )
# 32 "CalculatorParser.fsp"
                 : expr));
# 145 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 42 "CalculatorParser.fsp"
                                                         TimesExpr(_1,_3) 
                   )
# 42 "CalculatorParser.fsp"
                 : expr));
# 157 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 43 "CalculatorParser.fsp"
                                                         DivExpr(_1,_3) 
                   )
# 43 "CalculatorParser.fsp"
                 : expr));
# 169 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 44 "CalculatorParser.fsp"
                                                         PlusExpr(_1,_3) 
                   )
# 44 "CalculatorParser.fsp"
                 : expr));
# 181 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 45 "CalculatorParser.fsp"
                                                         MinusExpr(_1,_3) 
                   )
# 45 "CalculatorParser.fsp"
                 : expr));
# 193 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            let _3 = (let data = parseState.GetInput(3) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 46 "CalculatorParser.fsp"
                                                         PowExpr(_1,_3) 
                   )
# 46 "CalculatorParser.fsp"
                 : expr));
# 205 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 47 "CalculatorParser.fsp"
                                                         UPlusExpr(_2) 
                   )
# 47 "CalculatorParser.fsp"
                 : expr));
# 216 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 48 "CalculatorParser.fsp"
                                                         UMinusExpr(_2) 
                   )
# 48 "CalculatorParser.fsp"
                 : expr));
# 227 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : float)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 49 "CalculatorParser.fsp"
                                                         Num(_1) 
                   )
# 49 "CalculatorParser.fsp"
                 : expr));
# 238 "CalculatorParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = (let data = parseState.GetInput(2) in (Microsoft.FSharp.Core.Operators.unbox data : expr)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 50 "CalculatorParser.fsp"
                                                         _2 
                   )
# 50 "CalculatorParser.fsp"
                 : expr));
|]
# 250 "CalculatorParser.fs"
let tables () : FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 12;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : expr =
    Microsoft.FSharp.Core.Operators.unbox ((tables ()).Interpret(lexer, lexbuf, 0))

namespace Compiler

open System
open System.Collections.Generic

open Tokenizer

// This module is responsible for parsing tokens into a structured representation.
module Parser =
    type ParseError = string
    type Parser<'T> = TokenType list -> Result<'T, ParseError>
    let parse (parser: Parser<'T>) (tokens: TokenType list) : Result<'T, ParseError> =
        parser tokens
    let runParser (parser: Parser<'T>) (input: string) : Result<'T, ParseError> =
        let tokens = Tokenizer.tokenize input
        parse parser tokens


namespace Compiler

open System

// This module is responsible for tokenizing input strings into a sequence of tokens.
module Tokenizer =

    type TokenType =
        | Identifier of string
        | Keyword of string
        | Number of int
        | String of string
        | Operator of string
        | Punctuation of string
        | Whitespace

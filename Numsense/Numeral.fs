﻿module Ploeh.Numsense.Numeral

let toEnglish x = string x

let ofEnglish x = 
    let rec conv acc xs =        
        match xs with
        | []                                         -> acc
        | 'Z'::'E'::'R'::'O'::t                      -> conv  (0 + acc) t
        | 'O'::'N'::'E'::t                           -> conv  (1 + acc) t
        | 'T'::'W'::'O'::t                           -> conv  (2 + acc) t
        | 'T'::'H'::'R'::'E'::'E'::t                 -> conv  (3 + acc) t
        | 'F'::'O'::'U'::'R'::t                      -> conv  (4 + acc) t
        | 'F'::'I'::'V'::'E'::t                      -> conv  (5 + acc) t
        | 'S'::'I'::'X'::t                           -> conv  (6 + acc) t
        | 'S'::'E'::'V'::'E'::'N'::t                 -> conv  (7 + acc) t
        | 'E'::'I'::'G'::'H'::'T'::t                 -> conv  (8 + acc) t
        | 'N'::'I'::'N'::'E'::t                      -> conv  (9 + acc) t
        | 'T'::'E'::'N'::t                           -> conv (10 + acc) t
        | 'E'::'L'::'E'::'V'::'E'::'N'::t            -> conv (11 + acc) t
        | 'T'::'W'::'E'::'L'::'V'::'E'::t            -> conv (12 + acc) t
        | 'T'::'H'::'I'::'R'::'T'::'E'::'E'::'N'::t  -> conv (13 + acc) t
        | 'F'::'I'::'F'::'T'::'E'::'E'::'N'::t       -> conv (15 + acc) t
        | 'E'::'E'::'N'::t // matches 'een' in 'eighteen'
        | 'T'::'E'::'E'::'N'::t                      -> conv (10 + acc) t
        | 'T'::'W'::'E'::'N'::'T'::'Y'::t            -> conv (20 + acc) t
        | 'T'::'H'::'I'::'R'::'T'::'Y'::t            -> conv (30 + acc) t
        | _ -> -1

    match System.Int32.TryParse x with
    | true, i -> i
    | _ -> conv 0 (x.Trim().ToUpper(System.Globalization.CultureInfo "en") |> Seq.toList)
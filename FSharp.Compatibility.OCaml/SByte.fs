﻿(*

Copyright 2005-2009 Microsoft Corporation
Copyright 2012 Jack Pappas

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*)

//
[<CompilerMessage(
    "This module is for ML compatibility. \
    This message can be disabled using '--nowarn:62' or '#nowarn \"62\"'.",
    62, IsHidden = true)>]
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FSharp.Compatibility.OCaml.SByte

let compare (x:int8) y = compare x y

let zero = 0y
let one = 1y
let minus_one = - 1y
let neg (x:int8) =  - x
let add (x:int8) (y:int8) = x + y
let sub (x:int8) (y:int8) = x - y
let mul (x:int8) (y:int8) = x * y
let div (x:int8) (y:int8) = x / y
let rem (x:int8) (y:int8) = x % y
let succ (x:int8) = x + 1y
let pred (x:int8) = x - 1y
let abs (x:int8) = if x < zero then neg x else x
let max_int = 0x7Fuy
let min_int = 0x80y
let logand (x:int8) (y:int8) = x &&& y
let logor (x:int8) (y:int8) = x ||| y
let logxor (x:int8) (y:int8) = x ^^^ y
let lognot (x:int8) = ~~~ x
let shift_left (x:int8) (n:int) =  x <<< n
let shift_right (x:int8) (n:int) =  x >>> n
let of_uint8 (n:byte)   = sbyte n
let to_uint8 (x:int8) = byte x

let of_byte (n:byte)   = sbyte n
let to_byte (x:int8) = byte x

let of_int (n:int)   = sbyte n
let to_int (x:int8) = int x

let of_int16 (n:int16) = sbyte n
let to_int16 (x:int8)  = int16 x

let of_int32 (n:int32) = sbyte n
let to_int32 (x:int8) = int32 x


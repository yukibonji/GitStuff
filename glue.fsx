(**
Make sure everything is referenced
*)
#r "packages/FParsec/lib/net40-client/FParsecCS.dll"
#r "packages/FParsec/lib/net40-client/FParsec.dll"
#load "logParser.fsx"
#load "readLog.fsx"
open FParsec
open LogParser
open ReadLog


(**
Get the log and parse it
*)

let result = parseLog <| gitLog ()

let strResult =
    match result with
    | Success (x, _, _) -> sprintf "%A" x
    | Failure (e, _, _) -> sprintf "Error: %A" e

(**
Which results in:
*)

(*** include-value: strResult ***)
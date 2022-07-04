open System

open Exam1_2122
open Checker

let divisors (number : int) : string = ""

let rev (l : List<'a>) : List<'a> = []

let contentSearch (content : List<ContentType>) (searchArguments : List<string>) : List<ContentType> = []

let rec maxBy (projection : 'a -> 'b) (l : List<'a>): Option<'a> = None

let rec treeFoldDepth (f :  'state -> 'a -> 'state) (state : 'state) (t : Tree<'a>): 'state = ""

    



[<EntryPoint>]
let main argv =
  try
    let testedExercises =
      {
        Exercise1 = divisors
        Exercise2 = rev
        Exercise3 = contentSearch
        Exercise4 = maxBy
        Exercise5 = treeFoldDepth
      }
    printfn "%s" (validate testedExercises)
    0
  with
  | CheckerException msg -> 
      printfn "%s" msg
      1
  | :? Exception as e ->
      printfn "EXCEPTION: %s \nSTACK TRACE: %s" e.Message e.StackTrace
      1
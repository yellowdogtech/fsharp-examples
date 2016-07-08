// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.


// Define your library scripting code here

let square x = x * x

let sumOfSquares n =
    [1..n] |> List.map square |> List.sum

let sumOfSquaresMultiline n = 
    [1..n]
    |> List.map square
    |> List.sum

let answer = sumOfSquares 100


let myInt = 5
let myFloat = 3.14
let myString = "hello"

let twoToFive = [2;3;4;5]

let oneToFive = 1 :: twoToFive
let zeroToFive = [0;1] @ twoToFive

square 3

let add  x y = x + y

add 2 3

let evens list = 
    let isEven x = x%2 = 0
    List.filter isEven list

evens oneToFive

let sumOfSquaresTo100 = 
    List.sum (List.map square [1..100])


let sumOfSquaresTo100piped = 
    [1..100] |> List.map square |> List.sum

let sumOfSquaresTo100withFun =
    [1..100] |> List.map (fun x -> x * x) |> List.sum

let simplePatternMatch = 
    let x = "a"
    match x with
        | "a" -> printfn "x is a"
        | "b" -> printfn "x is b"
        | _ -> printfn "x is something else"

let validValue = Some(99)
let invalidValue = None

let optionPatternMatch input = 
    match input with
        | Some i -> printfn "input is an int=%d" i
        | None -> printfn "input is missing"

optionPatternMatch validValue
optionPatternMatch invalidValue

let twoTuple = 1,2
let threeTuple = "a",2,true

type Person = {First:string; Last:string}
let person1 = {First = "john"; Last = "Doe"}

type Temp = 
    | DegreesC of float
    | DegreesF of float

let temp = DegreesF 98.6

type Employee = 
    | Worker of Person
    | Manager of Employee list

let jdoe = {First = "john"; Last = "Doe"}
let worker = Worker jdoe

printfn "Printing an int %i. a float %f. a bool %b" 1 2.0 true
printfn "A string %s. and something generic %A" "hello" [1;2;3;4]

printfn "twoTuple=%A,\nPerson=%A,\nTemp=%A,\nEmployee=%A"
    twoTuple person1 temp worker

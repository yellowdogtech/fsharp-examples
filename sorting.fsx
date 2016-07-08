
let rec quicksort list =
    match list with
    |   [] ->
            []
    | firstElem::otherElements ->
        let smallerElements =
            otherElements
            |> List.filter (fun e -> e < firstElem)
            |> quicksort
        let largerElements =
            otherElements
            |> List.filter (fun e -> e >= firstElem)
            |> quicksort
        List.concat [smallerElements; [firstElem]; largerElements]

printfn "%A" (quicksort[1;5;23;18;9;1;3])


let rec quicksort2 list =
    match list with
    |   [] -> []
    | first::rest ->
        let smaller,larger = List.partition((>=) first) rest
        List.concat [quicksort2 smaller; [first]; quicksort2 larger]

printfn "%A" (quicksort2[1;5;23;18;9;1;3])



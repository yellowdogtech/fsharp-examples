type Shape =
| Circle of int
| Rectangle of int * int
| Polygon of (int * int) list
| Point of (int * int)

let draw shape =
    match shape with
    | Circle radius ->
        printfn "The circle has a radius of %d" radius
    | Rectangle (height,width) ->
        printfn "The rectangle is %d high by %d wide" height width
    | Polygon points ->
        printfn "The ploygon is made of these points %A" points   
    | _ -> printfn "I don't recognize this shape"

let circle = Circle(10)
let rect = Rectangle(4,5)
let polygon = Polygon([(1,1);(2,2);(3,3)])
let point = Point(2,2)

[circle;rect;polygon;point] |> List.iter draw
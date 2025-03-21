// Tail Recursion 1: Product of all elements in a list
let rec productTailRec lst acc =
    match lst with
    | [] -> acc
    | x::xs -> productTailRec xs (acc * x)

let product lst = productTailRec lst 1

// Test
printfn "Product of [1;2;3;4]: %d" (product [1;2;3;4])

// Tail Recursion 2: Product of all odd numbers from n to 1
let rec productOddTailRec n acc =
    if n <= 1 then acc
    else productOddTailRec (n - 2) (acc * n)

let productOdd n = productOddTailRec n 1

// Test
printfn "Product of odd numbers from 11 to 1: %d" (productOdd 11)
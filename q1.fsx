// Power function using integer exponents
let power exponent value = pown value exponent

// Partial application creates specialized functions
let square = power 2
let cube = power 3

// Usage examples
printfn "Square of 5: %d" (square 5)   // 25
printfn "Cube of 4: %d" (cube 4)       // 64
// Print a table of a given function f, computed by taylor series

// function to compute
let f = sin

let a = 0.0
let b = 1.0
let n = 10

// Define a function to compute f using naive taylor series method
let taylor_naive = f


// Define a function to do the same in a more efficient way
let taylor = f

let main =
   for i=0 to n do
     let x = a+(float i)/(float n)*(b-a)
     printfn "%5.2f  %10.6f  %10.6f   %10.6f" x (f x) (taylor_naive x) (taylor x)
// make sure to improve this table to include the required number of iterations
// for each of the methods

main


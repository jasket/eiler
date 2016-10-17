﻿// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.

let pattern = fun x -> x%3=0 || x%5=0
let find n = List.fold (+) 0 (List.filter pattern [3..n-1])

find 1000 //val it : int = 233168
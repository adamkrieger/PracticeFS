module PracticeFS.FSSource

open UsefulFuncs

type Person = {First:string; Last:string}

let multiplyXandY x y = x * y

let add1 x = x + 1

let cyl radius length : float =
    let pi = 3.14
    length * pi  * radius * radius

let isDivisor x y = 
    match (y % x) with
        | 0 -> true
        |_ -> false

//This is absolutely not optimized
let sumOfProperDivisors n =
    let array = [1..(n-1)]
    let properDivisors = array |> filter (fun f -> isDivisor f n)
    List.sum properDivisors

let isAmicable x =
    let dA = sumOfProperDivisors x
    let dB = sumOfProperDivisors (dA)
    match (x = dB) with
        | true -> match (x <> dA) with
                    | true -> true
                    | false -> false
        | false -> false

let sumOfAmicableNumbers x =
    let array = [1..x]
    let arrayOfAmicableNumbers = array |> filter (fun f -> isAmicable f)
    List.sum arrayOfAmicableNumbers
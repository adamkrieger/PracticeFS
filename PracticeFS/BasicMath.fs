module PracticeFS.BasicMath

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
    [1..(n-1)] |> filter (fun f -> isDivisor f n) |> List.sum

let isAmicable a =
    let dA = sumOfProperDivisors a
    let dB = sumOfProperDivisors dA
    match (a = dB) with
        | true -> match (a <> dA) with
                    | true -> true
                    | false -> false
        | false -> false

let sumOfAmicableNumbers x =
    [1..x] |> filter (fun f -> isAmicable f) |> List.sum
    

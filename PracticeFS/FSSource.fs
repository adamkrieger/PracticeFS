module PracticeFS.FSSource

type Person = {First:string; Last:string}

let multiplyXandY x y = x * y

let add1 x = x + 1

//let getFactors x =

let isFactor x y = 
    match ((y % x) = 0) with
        | true -> true
        | false -> false

let cyl radius length : float =
    let pi = 3.14
    length * pi  * radius * radius
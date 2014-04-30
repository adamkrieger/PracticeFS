module PracticeFS.RecursionSamples


let add1 x = x + 1

let rec countUpTo500 current =
    let next = current |> add1
    match current with
        | 500 -> true
        |_ -> next |> countUpTo500



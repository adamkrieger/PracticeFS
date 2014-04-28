module UsefulFuncs


//taken from http://en.wikibooks.org/wiki/F_Sharp_Programming/Lists
let rec filter predicate = function
    | [] -> []
    | hd :: tl ->
        match predicate hd with
            | true -> hd::filter predicate tl 
            | false -> filter predicate tl


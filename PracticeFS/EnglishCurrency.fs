module PracticeFS.EnglishCurrency

//Define a domain of possible coins
//Give those coins constant value

//Eight applicable coins: 1p, 2p, 5p, 10p, 20p, 50p, 1lb, 2lb
//How many ways can 2lb be made?

//Possibility 1: Start with largest denomination, then break down last coin
//eg    200
//      100,100
//      100,50,50
//      100,50,20,20,10
//      etc

let sortCoins coins =
    coins |> Array.sort |> Array.rev

let getCountOfCombinationsThatEqualTotal valueList total =
    5

let combinationsOfEnglishCurrency total =
    [|1;2;5;10;20;50;100;200|] |> getCountOfCombinationsThatEqualTotal
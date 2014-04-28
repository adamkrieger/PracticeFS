// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open PracticeFS.FSSource


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    isDivisor 2 4 |> printfn "%b"

    isAmicable 220 |> printfn "Is 220 amicable: %b"
    isAmicable 284 |> printfn "is 284 amicable: %b"
    isAmicable 4 |> printfn "Is 4 amicable: %b"

    sumOfAmicableNumbers 9999 |> printfn "%d"

    //printfn "%d" sumOfAmicableNumbers 10000

    let input = System.Console.ReadKey()

    0 // return an integer exit code
   
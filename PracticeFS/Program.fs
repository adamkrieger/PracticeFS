// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open PracticeFS.BasicMath
open PracticeFS.EnglishCurrency
open PracticeFS.RecursionSamples

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let x = PracticeFS.RecursionSamples.countUpTo500 1

    let input = System.Console.ReadKey()

    0 // return an integer exit code
   
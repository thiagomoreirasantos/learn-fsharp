﻿// For more information see https://aka.ms/fsharp-console-apps

open FSharp.Data

[<Literal>]
let root = __SOURCE_DIRECTORY__

let PremierLeague = new CsvProvider<"./dataset/2020s/2020-21/eng.1.csv", ResolutionFolder=root>()

let plfilter = PremierLeague.Filter(fun row -> row.``Team 1`` = "Arsenal FC" || row.``Team 2`` = "Arsenal FC")

for row in plfilter.Rows |> Seq.truncate 10 do
    printfn "Match: %s,%s,%s"  row.``Team 1``  row.FT row.``Team 2``
    printfn "Date: %s" (row.Date.ToString "yyyy/MM/dd")
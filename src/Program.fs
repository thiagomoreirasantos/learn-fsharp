// For more information see https://aka.ms/fsharp-console-apps

open Deedle

let root = __SOURCE_DIRECTORY__
let premierL2020 = Frame.ReadCsv(root + "./dataset/2020s/2020-21/eng.5.csv")




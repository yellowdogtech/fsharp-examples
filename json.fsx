#r "FSharp.Data.2.3.1/lib/net40/FSharp.Data.dll"

open FSharp.Data
open FSharp.Data.JsonExtensions

let info = 
    JsonValue.Parse("""
        {"name": "Tomas", "born": 1985,
         "siblings": ["Jan", "Alexander"]} """)

let n = info?name
printfn "%s (%d)" (info?name.AsString()) (info?born.AsInteger())

for sib in info?siblings do
    printfn "%s" (sib.AsString())


let webReq  = 
    "http://api.worldbank.org/country/cz/indicator/" + 
    "GC.DOD.TOTL.GD.ZS?format=json"
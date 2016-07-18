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


let wbReq  = 
    "http://api.worldbank.org/country/cz/indicator/" + 
    "GC.DOD.TOTL.GD.ZS?format=json"

let value =
    JsonValue.Load(wbReq)

match value with
| JsonValue.Array [| info; data |] ->
    let page, pages, total = info?page, info?pages, info?total
    printfn
        "Showing page %d of %d Total records %d"
        (page.AsInteger()) (pages.AsInteger())  (total.AsInteger())

    for record in data do
        if record?value <> JsonValue.Null then
            printfn "%d: %f" (record?date.AsInteger()) 
                             (record?value.AsFloat())  
| _ -> printf "failed"

#r "../packages/FSharp.Data.2.2.3/lib/net40/FSharp.Data.dll"

open FSharp.Data

type StockProvider = CsvProvider<"http://ichart.finance.yahoo.com/table.csv?s=MSFT">
let context = StockProvider.Load("http://ichart.finance.yahoo.com/table.csv?s=MSFT")

context.Rows |> Seq.filter(fun r -> r.Close > r.Open)
             |> Seq.map(fun r -> r.Date, r.Volume)
             |> Seq.sortBy(fun (d,v) -> v)
             |> Seq.head



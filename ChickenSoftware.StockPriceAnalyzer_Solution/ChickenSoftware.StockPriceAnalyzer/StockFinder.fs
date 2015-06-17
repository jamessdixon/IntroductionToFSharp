namespace ChickenSoftware.StockPriceAnalyzer

open FSharp.Data

type StockProvider = CsvProvider<"http://ichart.finance.yahoo.com/table.csv?s=AET">

type IStockFinder =
   abstract member GetHighVolumeUpDay : string -> System.DateTime * int

type YahooStockFinder() = 
    interface IStockFinder with
        member this.GetHighVolumeUpDay (ticker:string) = 
            let context = StockProvider.Load("http://ichart.finance.yahoo.com/table.csv?s="+ ticker)
            context.Rows |> Seq.filter(fun r -> r.Close > r.Open)
                         |> Seq.map(fun r -> r.Date, r.Volume)
                         |> Seq.sortBy(fun (d,v) -> v)
                         |> Seq.head

type InMemoryStockFinder() = 
    interface IStockFinder with
        member this.GetHighVolumeUpDay (ticker:string) = 
            new System.DateTime(2015,3,1),1000000
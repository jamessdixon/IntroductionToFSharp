open System

[<EntryPoint>]
let main argv = 
    let addTen x = x + 10
    let multiplyFive x = x * 5
    let subtractTwo x = x - 2

    //Way #1
    let functionArray = [| addTen; multiplyFive; subtractTwo |] 
    let calculateAnswer fa x = fa |> Array.fold(fun acc fa -> fa acc) x
    printfn "%A" (calculateAnswer functionArray 10)

    //Way #2
    let calculateAnswer' x =
        addTen x
        |> multiplyFive 
        |> subtractTwo
    printfn "%A" (calculateAnswer' 10)

    //Way #3
    let calculateAnswer'' =
         addTen >> multiplyFive >> subtractTwo
    printfn "%A" (calculateAnswer'' 10)
    
    let wait = Console.ReadKey()
    0
module ReprogrammerTests

open Xunit
open FsUnit.Xunit

[<Fact>]
let ``Add test``() =
    let a = [ 1; 2; 2; 5; 1; 1; 1; 2; 99 ]
    let av = [ 0 .. (List.length a) - 1 ] |> List.map (fun v -> (v, a.[v]))
    let expected = (5, 4)
    let actual = ReprogrammerService.Reprogrammer.Add 0 av
    actual.[5] |> should (equal) expected

let rec tryfunc (a: int) (b: int) (lst: (int * int) List) =
    printfn "%A" (a, b)
    if a > 99 then
        if b > 99 then (0, 0)
        else tryfunc 0 (b + 1) lst
    else
        let newlist =
            lst
            |> List.map (fun (k, v) ->
                if k = 1 then (k, a)
                elif k = 2 then (k, b)
                else (k, v))

        let result = ReprogrammerService.Reprogrammer.Prog 0 newlist
        match result.[0] with
        | (_, 19690720) -> (a, b)
        | _ -> tryfunc (a + 1) b lst

[<Fact>]
let ``Mult test``() =
    let a =
        [ 1
          12
          2
          3
          1
          1
          2
          3
          1
          3
          4
          3
          1
          5
          0
          3
          2
          9
          1
          19
          1
          19
          5
          23
          1
          9
          23
          27
          2
          27
          6
          31
          1
          5
          31
          35
          2
          9
          35
          39
          2
          6
          39
          43
          2
          43
          13
          47
          2
          13
          47
          51
          1
          10
          51
          55
          1
          9
          55
          59
          1
          6
          59
          63
          2
          63
          9
          67
          1
          67
          6
          71
          1
          71
          13
          75
          1
          6
          75
          79
          1
          9
          79
          83
          2
          9
          83
          87
          1
          87
          6
          91
          1
          91
          13
          95
          2
          6
          95
          99
          1
          10
          99
          103
          2
          103
          9
          107
          1
          6
          107
          111
          1
          10
          111
          115
          2
          6
          115
          119
          1
          5
          119
          123
          1
          123
          13
          127
          1
          127
          5
          131
          1
          6
          131
          135
          2
          135
          13
          139
          1
          139
          2
          143
          1
          143
          10
          0
          99
          2
          0
          14
          0 ]
    let av = [ 0 .. (List.length a) - 1 ] |> List.map (fun v -> (v, a.[v]))
    let expected = (2, 12)
    let actual = tryfunc 0 0 av

    actual |> should (equal) expected
(*
[<Fact>]
let ``Add test``() =
    let a = [ 1; 2; 2; 5; 1; 1; 1; 2; 99 ]

    let av = [ 0 .. (List.length a) - 1 ] |> List.map (fun v -> (v, a.[v]))

    let c = Reprogrammer.add 0 av
    c.[5] |> should (equal) 4

let a = [1;2;2;5;1;1;1;2;99]

let av = [0..(List.length a)-1] |> List.map( fun (v)-> (v, a.[v]))

let b = prog 0 av
let c = Add 2 av;;
;;c
*)

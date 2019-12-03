namespace ReprogrammerService

module Reprogrammer =
    let rec Add (pointer: int) (lst: (int * int) List) =
        let (_, apointer) = lst.[pointer + 1]
        let (_, bpointer) = lst.[pointer + 2]
        let (_, targetpointer) = lst.[pointer + 3]
        let (_, avalue) = lst.[apointer]
        let (_, bvalue) = lst.[bpointer]

        let newlst =
            lst
            |> List.map (fun (k, v) ->
                if k = targetpointer then (k, avalue + bvalue)
                else (k, v))
        newlst

    let rec Mult (pointer: int) (lst: (int * int) List) =
        let (_, apointer) = lst.[pointer + 1]
        let (_, bpointer) = lst.[pointer + 2]
        let (_, targetpointer) = lst.[pointer + 3]
        let (_, avalue) = lst.[apointer]
        let (_, bvalue) = lst.[bpointer]

        let newlst =
            lst
            |> List.map (fun (k, v) ->
                if k = targetpointer then (k, avalue * bvalue)
                else (k, v))
        newlst


    let rec Prog (pointer: int) (lst: (int * int) List) =
        let vals = lst |> List.map (fun (a, b) -> b)
        if pointer > lst.Length then
            lst
        else
            let (_, p) = lst.[pointer]

            let newlist =
                match p with
                | 1 -> Add pointer lst
                | 2 -> Mult pointer lst
                | 99 -> lst
                | _ -> lst

            let newpointer = pointer + 4
            Prog newpointer newlist

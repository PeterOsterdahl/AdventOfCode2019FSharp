namespace FuelCalculationService2

module FuelCalculation =
    let FromMass(mass: int) =
        let fuel = mass / 3 - 2
        match fuel with
        | i when i <= 0 -> 0
        | _ -> fuel

    let rec FromListOfMass l =
        match l with
        | [] -> 0
        | [ m ] -> FromMass m
        | m :: T -> FromMass m + FromListOfMass T

    let readlines (filepath: string) = System.IO.File.ReadLines(filepath)

    let FromFile filepath =
        let moduleLlist =
            readlines filepath
            |> Seq.map int
            |> List.ofSeq
        FromListOfMass moduleLlist

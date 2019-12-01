module RecursiveFuelCalculationTests

open Xunit
open FsUnit.Xunit


type ``Given a FuelCalculationService2 and a mass of m``() =
    [<Theory>]
    [<InlineData(12, 2)>]
    [<InlineData(14, 2)>]
    [<InlineData(1969, 966)>]
    [<InlineData(100756, 50346)>]
    member x.``the fuel needed is`` (m, expected) =
        let actual = FuelCalculationService2.FuelCalculation.FromMass m
        actual |> should (equal) expected



[<Fact>]
let InputDataReturnsCorrectly() =
    let expected = 4994898
    let actual = FuelCalculationService2.FuelCalculation.FromFile "../../../../input.data"
    actual |> should (equal) expected

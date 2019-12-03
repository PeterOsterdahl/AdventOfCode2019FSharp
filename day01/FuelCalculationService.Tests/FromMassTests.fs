module FromMassTests

open Xunit
open FsUnit.Xunit

[<Fact>]
let NotRoundedCaluclationIsCorrect() =
    let expected = 2
    let actual = FuelCalculationService1.FuelCalculation.FromMass 12

    Assert.Equal(expected, actual)

type ``Given a FuelCalculationService1 and a mass of m``() =
    [<Theory>]
    [<InlineData(12, 2)>]
    [<InlineData(14, 2)>]
    [<InlineData(11, 1)>]
    [<InlineData(0, 0)>]
    [<InlineData(3, 0)>]
    [<InlineData(6, 0)>]
    [<InlineData(1969, 654)>]
    [<InlineData(100756, 33583)>]
    member x.``the fuel needed is`` (m, expected) =
        let actual = FuelCalculationService1.FuelCalculation.FromMass m
        actual |> should (equal) expected

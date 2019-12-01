module FromListOfMassTests

open Xunit
open FsUnit.Xunit


[<Fact>]
let EmptyListReturnsZero() =
    let expected = 0
    let testlist = []
    let actual = FuelCalculationService1.FuelCalculation.FromListOfMass testlist
    actual |> should (equal) expected



[<Fact>]
let SingleListReturnsValueForSingle() =
    let expected = 2
    let testlist = [ 12 ]
    let actual = FuelCalculationService1.FuelCalculation.FromListOfMass testlist
    actual |> should (equal) expected

[<Fact>]
let MultiplesReturnSumOfAllFuelConsumtions() =
    let expected = 2 + 2 + 654 + 33583
    let testlist = [ 12; 14; 1969; 100756 ]
    let actual = FuelCalculationService1.FuelCalculation.FromListOfMass testlist
    actual |> should (equal) expected

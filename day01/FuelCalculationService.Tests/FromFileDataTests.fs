module FromFileDataTests

open Xunit
open FsUnit.Xunit


[<Fact>]
let TestDataReturnsCorrectly() =
    let expected = 4
    let actual = FuelCalculationService1.FuelCalculation.FromFile "../../../Testdata.data"
    actual |> should (equal) expected




[<Fact>]
let InputDataReturnsCorrectly() =
    let expected = 3331849
    let actual = FuelCalculationService1.FuelCalculation.FromFile "../../../../input.data"
    actual |> should (equal) expected

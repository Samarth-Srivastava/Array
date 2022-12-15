using Array.Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Array.webapi.Controllers;

[ApiController]
[Route("Array.api/[controller]")]
public class ArrayController : ControllerBase

{
	protected readonly ISolution _app;
	public ArrayController(ISolution app)
	{
		_app = app;
	}

	[HttpPost]
	[Route("Add_Very_Big_Numbers")]
	public IActionResult Add_Very_Big_Numbers(string num1, string num2)
	{
		return new JsonResult(_app.Add_Very_Big_Numbers(num1, num2));
	}

    [HttpPost]
	[Route("CalculateLength")]
	public IActionResult CalculateLength(int maxLocation, int minLocation, int len)
	{
		return new JsonResult(_app.CalculateLength(maxLocation, minLocation, len));
	}

    [HttpPost]
	[Route("CheckIfThereExistsASubSetWithSumK")]
	public IActionResult CheckIfThereExistsASubSetWithSumK(List<int> A, int k)
	{
		return new JsonResult(_app.CheckIfThereExistsASubSetWithSumK(A, k));
	}

    [HttpPost]
	[Route("CheckSumPair")]
	public IActionResult CheckSumPair(int[] arr, int k)
	{
		return new JsonResult(_app.CheckSumPair(arr, arr.Length, k));
	}

    [HttpPost]
	[Route("ClosestMinMax")]
	public IActionResult ClosestMinMax(int[] arr)
	{
		return new JsonResult(_app.ClosestMinMax(arr, arr.Length));
	}

    [HttpPost]
	[Route("CountAGPairs")]
	public IActionResult CountAGPairs(char[] arr)
	{
		return new JsonResult(_app.CountAGPairs(arr, arr.Length));
	}

    [HttpPost]
	[Route("CountAtleast1GreaterElement")]
	public IActionResult CountAtleast1GreaterElement(int[] arr)
	{
		return new JsonResult(_app.CountAtleast1GreaterElement(arr, arr.Length));
	}

    [HttpPost]
	[Route("EvenLengthSubarrayWithEvenEdgeElements")]
	public IActionResult EvenLengthSubarrayWithEvenEdgeElements(int[] arr)
	{
		return new JsonResult(_app.EvenLengthSubarrayWithEvenEdgeElements(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetAllSubArrays")]
	public IActionResult GetAllSubArrays(int[] arr)
	{
		return new JsonResult(_app.GetAllSubArrays(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetAllSubsetsList")]
	public IActionResult GetAllSubsets(List<int> A)
	{
		return new JsonResult(_app.GetAllSubsets(A));
	}

    [HttpPost]
	[Route("GetEquilibriumIndexesOfArray")]
	public IActionResult GetEquilibriumIndexesOfArray(int[] arr)
	{
		return new JsonResult(_app.GetEquilibriumIndexesOfArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetIndexOfSubarrayOfSizeBWithLeastAverage")]
	public IActionResult GetIndexOfSubarrayOfSizeBWithLeastAverage(List<int> A, int B)
	{
		return new JsonResult(_app.GetIndexOfSubarrayOfSizeBWithLeastAverage(A, B));
	}

    [HttpPost]
	[Route("GetNextMaxLocation")]
	public IActionResult GetNextMaxLocation(int[] arr, int max, int minLoc)
	{
		return new JsonResult(_app.GetNextMaxLocation(arr, arr.Length, max, minLoc));
	}

    [HttpPost]
	[Route("GetNextMinLocation")]
	public IActionResult GetNextMinLocation(int[] arr, int min, int maxLoc)
	{
		return new JsonResult(_app.GetNextMinLocation(arr, arr.Length, min, maxLoc));
	}

    [HttpPost]
	[Route("GetPrefixEvenArray")]
	public IActionResult GetPrefixEvenArray(int[] arr)
	{
		return new JsonResult(_app.GetPrefixEvenArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetPrefixMaxArray")]
	public IActionResult GetPrefixMaxArray(int[] arr)
	{
		return new JsonResult(_app.GetPrefixMaxArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetPrefixMaxArrayList")]
	public IActionResult GetPrefixMaxArray(List<int> arr)
	{
		return new JsonResult(_app.GetPrefixMaxArray(arr, arr.Count()));
	}

    [HttpPost]
	[Route("GetPrefixOddArray")]
	public IActionResult GetPrefixOddArray(int[] arr)
	{
		return new JsonResult(_app.GetPrefixOddArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetPrefixSumArray")]
	public IActionResult GetPrefixSumArray(int[] arr)
	{
		return new JsonResult(_app.GetPrefixSumArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetSpecialIndexesOfArray")]
	public IActionResult GetSpecialIndexesOfArray(int[] arr)
	{
		return new JsonResult(_app.GetSpecialIndexesOfArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetSuffixMaxArray")]
	public IActionResult GetSuffixMaxArray(int[] arr)
	{
		return new JsonResult(_app.GetSuffixMaxArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetSuffixMaxArrayList")]
	public IActionResult GetSuffixMaxArray(List<int> arr)
	{
		return new JsonResult(_app.GetSuffixMaxArray(arr, arr.Count()));
	}

    [HttpPost]
	[Route("GetSuffixSumArray")]
	public IActionResult GetSuffixSumArray(int[] arr)
	{
		return new JsonResult(_app.GetSuffixSumArray(arr, arr.Length));
	}

    [HttpPost]
	[Route("GetSumOfAllSubArrays")]
	public IActionResult GetSumOfAllSubArrays(int[] arr)
	{
		return new JsonResult(_app.GetSumOfAllSubArrays(arr, arr.Length));
	}

    [HttpPost]
	[Route("LargestPositiveSubarray")]
	public IActionResult LargestPositiveSubarray(List<int> A)
	{
		return new JsonResult(_app.LargestPositiveSubarray(A));
	}

    [HttpPost]
	[Route("Leaders")]
	public IActionResult Leaders(int[] arr)
	{
		return new JsonResult(_app.Leaders(arr, arr.Length));
	}

    [HttpPost]
	[Route("Max")]
	public IActionResult Max(int a, int b)
	{
		return new JsonResult(_app.Max(a, b));
	}

    [HttpPost]
	[Route("ArrayMax")]
	public IActionResult Max(int[] arr)
	{
		return new JsonResult(_app.Max(arr, arr.Length));
	}

    [HttpPost]
	[Route("maxSubArraySum")]
	public IActionResult maxSubArraySum(int[] arr)
	{
		return new JsonResult(_app.maxSubArraySum(arr, arr.Length));
	}

    [HttpPost]
	[Route("Min")]
	public IActionResult Min(int a, int b)
	{
		return new JsonResult(_app.Min(a, b));
	}

    [HttpPost]
	[Route("ArrayMin")]
	public IActionResult Min(int[] arr)
	{
		return new JsonResult(_app.Min(arr, arr.Length));
	}

    [HttpPost]
	[Route("minBulbsToSwitchOn")]
	public IActionResult minBulbsToSwitchOn(int[] arr)
	{
		return new JsonResult(_app.minBulbsToSwitchOn(arr, arr.Length));
	}

    [HttpPost]
	[Route("MinimizeDiversity")]
	public IActionResult MinimizeDiversity(string A, int B)
	{
		return new JsonResult(_app.MinimizeDiversity(A, B));
	}

    [HttpPost]
	[Route("Multiply_Very_Big_Numbers")]
	public IActionResult Multiply_Very_Big_Numbers(string num1, string num2)
	{
		return new JsonResult(_app.Multiply_Very_Big_Numbers(num1, num2));
	}

    [HttpPost]
	[Route("PickFromBothSides")]
	public IActionResult PickFromBothSides(int[] arr, int B)
	{
		return new JsonResult(_app.PickFromBothSides(arr, arr.Length, B));
	}

    [HttpPost]
	[Route("PickFromBothSides2")]
	public IActionResult PickFromBothSides2(int[] arr, int B)
	{
		return new JsonResult(_app.PickFromBothSides2(arr, arr.Length, B));
	}

    [HttpPost]
	[Route("PickFromBothSides2List")]
	public IActionResult PickFromBothSides2List(List<int> arr, int B)
	{
		return new JsonResult(_app.PickFromBothSides2List(arr, arr.Count(), B));
	}

    [HttpPost]
	[Route("Reverse")]
	public IActionResult Reverse(int[] arr, int start, int end)
	{
		return new JsonResult(_app.Reverse(arr, start, end));
	}

    [HttpPost]
	[Route("RotateLeft")]
	public IActionResult RotateLeft(int[] arr, int k)
	{
		return new JsonResult(_app.RotateLeft(arr, arr.Length, k));
	}

    [HttpPost]
	[Route("RotateLeftList")]
	public IActionResult RotateLeft(List<int> arr, int k)
	{
		return new JsonResult(_app.RotateLeft(arr, arr.Count(), k));
	}

    [HttpPost]
	[Route("RotateRight")]
	public IActionResult RotateRight(int[] arr, int k)
	{
		return new JsonResult(_app.RotateRight(arr, arr.Length, k));
	}

    [HttpPost]
	[Route("RotateRightList")]
	public IActionResult RotateRight(List<int> arr, int k)
	{
		return new JsonResult(_app.RotateRight(arr, arr.Count(), k));
	}

    [HttpPost]
	[Route("SecondMax")]
	public IActionResult SecondMax(int[] arr)
	{
		return new JsonResult(_app.SecondMax(arr, arr.Length));
	}

    [HttpPost]
	[Route("SubArrayWithSum0")]
	public IActionResult SubArrayWithSum0(int[] arr)	
	{
		return new JsonResult(_app.SubArrayWithSum0(arr, arr.Length));
	}
}

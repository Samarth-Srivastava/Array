namespace Array.Application.Contract
{
    public interface ISolution
    {
        string Add_Very_Big_Numbers(string num1, string num2);
        int CalculateLength(int maxLocation, int minLocation, int len);
        bool CheckIfThereExistsASubSetWithSumK(List<int> A, int k);
        bool CheckSumPair(int[] arr, int N, int k);
        int ClosestMinMax(int[] arr, int N);
        int CountAGPairs(char[] arr, int N);
        int CountAtleast1GreaterElement(int[] arr, int N);
        string EvenLengthSubarrayWithEvenEdgeElements(int[] arr, int N);
        int[][] GetAllSubArrays(int[] arr, int N);
        List<List<int>> GetAllSubsets(List<int> A);
        int[] GetEquilibriumIndexesOfArray(int[] arr, int N);
        int[] GetIndexOfSubarrayOfSizeBWithLeastAverage(List<int> A, int B);
        int GetNextMaxLocation(int[] arr, int N, int max, int minLoc);
        int GetNextMinLocation(int[] arr, int N, int min, int maxLoc);
        int[] GetPrefixEvenArray(int[] arr, int N);
        int[] GetPrefixMaxArray(int[] arr, int N);
        List<int> GetPrefixMaxArray(List<int> arr, int N);
        int[] GetPrefixOddArray(int[] arr, int N);
        int[] GetPrefixSumArray(int[] arr, int N);
        int[] GetSpecialIndexesOfArray(int[] arr, int N);
        int[] GetSuffixMaxArray(int[] arr, int N);
        List<int> GetSuffixMaxArray(List<int> arr, int N);
        int[] GetSuffixSumArray(int[] arr, int N);
        int GetSumOfAllSubArrays(int[] arr, int N);
        List<int> LargestPositiveSubarray(List<int> A);
        int[] Leaders(int[] arr, int N);
        int Max(int a, int b);
        int Max(int[] arr, int N);
        int[] maxSubArraySum(int[] arr, int N);
        int Min(int a, int b);
        int Min(int[] arr, int N);
        int minBulbsToSwitchOn(int[] arr, int N);
        int MinimizeDiversity(string A, int B);
        string Multiply_Very_Big_Numbers(string num1, string num2);
        int PickFromBothSides(int[] arr, int N, int B);
        int PickFromBothSides2(int[] arr, int N, int B);
        int PickFromBothSides2List(List<int> arr, int N, int B);
        int[] Reverse(int[] arr, int start, int end);
        int[] RotateLeft(int[] arr, int n, int k);
        List<int> RotateLeft(List<int> arr, int n, int k);
        int[] RotateRight(int[] arr, int n, int k);
        List<int> RotateRight(List<int> arr, int n, int k);
        int SecondMax(int[] arr, int N);
        void solve();
        int[] SubArrayWithSum0(int[] arr, int N);
    }
}


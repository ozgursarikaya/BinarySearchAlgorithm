namespace BinarySearchAlgorithm
{
    public class BinarySearch
    {
        // Recursive binary search function
        public int Search(int[] arr, int low, int high, int target)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == target)
                    return mid;

                // If the element is smaller than the middle element, then it can only be present in the left subarray
                if (arr[mid] > target)
                    return Search(arr, low, mid - 1, target);

                // Else the element can only be present in the right subarray
                return Search(arr, mid + 1, high, target);
            }

            // Element is not present in the array
            return -1;
        }

        // Iterative binary search function
        public int Iterative(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // Check if target is present at mid
                if (arr[mid] == target)
                    return mid;

                // If target greater, ignore left half
                if (arr[mid] < target)
                    low = mid + 1;

                // If target is smaller, ignore right half
                else
                    high = mid - 1;
            }

            // If target is not present in the array
            return -1;
        }
    }
}

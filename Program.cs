
using BinarySearchAlgorithm;

BinarySearch bs = new BinarySearch();

int[] arr = { 2, 3, 4, 10, 40 };
int target = 10;

int resultRecursive = bs.Search(arr, 0, arr.Length - 1, target);
int resultIterative = bs.Iterative(arr, target);

if (resultRecursive != -1)
    Console.WriteLine("Element found at index (Recursive): " + resultRecursive);
else
    Console.WriteLine("Element not found (Recursive)");

if (resultIterative != -1)
    Console.WriteLine("Element found at index (Iterative): " + resultIterative);
else
    Console.WriteLine("Element not found (Iterative)");

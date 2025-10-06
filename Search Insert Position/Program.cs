using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Test cases for SearchInsertPosition method
        Console.WriteLine(SearchInsertPosition(new int[] { 1, 2, 3 }, 3));         // Output: 2 (3 found at index 2)
        Console.WriteLine(SearchInsertPosition(new int[] { 1, 4, 6, 8, 9 }, 7));   // Output: 3 (7 should be inserted at index 3)
        Console.WriteLine(SearchInsertPosition(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8)); // Output: 7 (insert after last element)
        Console.WriteLine(SearchInsertPosition(new int[] { 1, 2, 3 }, 0));         // Output: 0 (insert before first element)
    }

    /// <summary>
    /// Finds the index of the target in a sorted array,
    /// or the position where it should be inserted if not found.
    /// </summary>
    /// <param name="nums">Sorted integer array (ascending order)</param>
    /// <param name="target">Value to search for</param>
    /// <returns>Index of target or correct insert position</returns>
    public static int SearchInsertPosition(int[] nums, int target)
    {
        int firstindex = 0;                 // Start of the search range
        int lastindex = nums.Length - 1;    // End of the search range

        // Continue searching while the range is valid
        while (firstindex <= lastindex)
        {
            // Calculate the middle index
            int mid = (firstindex + lastindex) / 2;

            // If the middle element is equal to target → found it
            if (nums[mid] == target)
                return mid;

            // If the middle element is smaller than target → search right half
            else if (nums[mid] < target)
                firstindex = mid + 1;

            // If the middle element is greater than target → search left half
            else
                lastindex = mid - 1;
        }

        // If not found, 'firstindex' points to the position where target should be inserted
        return firstindex;
    }
}

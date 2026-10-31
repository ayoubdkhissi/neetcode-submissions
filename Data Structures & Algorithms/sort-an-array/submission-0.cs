public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums);
        return nums; 
    }
    void MergeSort(int[] arr)
    {

        if (arr.Length <= 1)
            return;

        var mid = arr.Length / 2;

        var left = arr[..mid];
        var right = arr[mid..];

        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }

    void Merge(int[] arr, int[] left, int[] right)
    {
        var l = 0;
        var r = 0;
        var k = 0;

        while(l < left.Length && r < right.Length)
        {
            if (left[l] <= right[r])
            {
                arr[k] = left[l];
                l++;
            }
            else
            {
                arr[k] = right[r];
                r++;
            }

            k++;
        }

        while(l < left.Length)
        {
            arr[k] = left[l];
            k++;
            l++;
        }
        while(r < right.Length)
        {
            arr[k] = right[r];
            k++;
            r++;
        }
    }   
}
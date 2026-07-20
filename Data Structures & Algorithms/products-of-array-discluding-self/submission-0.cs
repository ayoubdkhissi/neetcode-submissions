public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var prefixProducts = new int[n];
        var suffixProducts = new int[n];
        var ans = new int[n];

        prefixProducts[0] = 1;
        suffixProducts[n-1] = 1;
        for (int i = 1, j = n - 2; i < n && j >= 0; i++, j--)
        {
            prefixProducts[i] = nums[i - 1] * prefixProducts[i - 1];
            suffixProducts[j] = nums[j + 1] * suffixProducts[j + 1];
        }

        for(int i=0; i<n; i++)
        {
            ans[i] = prefixProducts[i] * suffixProducts[i];
        }

        return ans;
    }
}

/*

    [1, 2, 4, 6] ==> [1, 1, 2, 8] | [48,24,6,1]
    [-1,0,1,2,3] ==> [ ,0,6,6,3]
*/
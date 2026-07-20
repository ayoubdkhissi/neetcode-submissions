public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[n];
        ans[0] = 1;

        for (int i = 1; i < n; i++)
        {
            ans[i] = nums[i - 1] * ans[i - 1];
        }

        var post = 1;
        for(int j = n - 2; j >= 0; j--)
        {
            post = nums[j + 1] * post;
            ans[j] = ans[j] * post;
        }

        return ans;
    }
}

/*

    [1, 2, 4, 6] ==> [1, 1, 2, 8] | [48,24,6,1]
    [-1,0,1,2,3] ==> [ ,0,6,6,3]
*/
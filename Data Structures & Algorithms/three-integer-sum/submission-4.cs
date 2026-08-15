public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        var n = nums.Length;
        var ans = new List<List<int>>();

        nums = nums.OrderBy(x => x).ToArray();

        for(int i=0; i<n; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            var l = i + 1;
            var r = n - 1;
            while(l < r)
            {
                var threesome = nums[i] + nums[l] + nums[r];
                if (threesome > 0)
                    r--;
                else if(threesome < 0)
                    l++;
                else
                {
                    ans.Add([nums[i], nums[l], nums[r]]);
                    l++;
                    while (nums[l] == nums[l - 1] && l < r)
                        l++;
                }

            }
        }
        return ans;

    }
}

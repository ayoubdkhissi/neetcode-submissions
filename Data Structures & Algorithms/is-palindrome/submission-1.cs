public class Solution {
    public bool IsPalindrome(string s)
    {
        var list = s.ToLower().Where(x => (x >= 97 && x<=122) || (x >= 48 && x <= 57)).ToList();
        var n = list.Count;
        for(int i=0; i<= n/2 - 1; i++)
        {
            if (list[i] != list[n - i - 1])
                return false;
        }

        return true;
    }
}

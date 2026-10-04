public class Solution {
    public void ReverseString(char[] s)
    {
        var n = s.Length;
        char tmp;
        for(int i=0; i<n/2; i++)
        {
            tmp = s[i];
            s[i] = s[n - 1 - i];
            s[n - 1 - i] = tmp;
        }
    }
}
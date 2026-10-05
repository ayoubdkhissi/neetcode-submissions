public class Solution
{
    public bool ValidPalindrome(string s)
    {
        var n = s.Length;
        var l = 0;
        var r = n - 1;

        while(l<r)
        {
            if (s[l] != s[r])
            {
                // removing l case
                var testStr = s[(l + 1)..(r+1)];
                var palindrom = true;
                for(int i=0;i<testStr.Length/2; i++)
                {
                    if (testStr[i] != testStr[testStr.Length - 1 - i])
                    {
                        palindrom = false;
                        break;
                    }
                        
                }
                if (palindrom)
                    return true;

                palindrom = true;
                // removing r case;
                testStr = s[l..r];
                for (int i = 0; i < testStr.Length / 2; i++)
                {
                    if (testStr[i] != testStr[testStr.Length - 1 - i])
                    {
                        palindrom = false;
                        break;
                    }
                }

                return palindrom;
            }
            r--;
            l++;
        }

        return true;
    }
}
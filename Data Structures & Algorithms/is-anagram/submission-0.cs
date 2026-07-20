public class Solution {
    public bool IsAnagram(string s, string t)
    {
        return string.Join("", s.Order()) == string.Join("", t.Order());
    }
}

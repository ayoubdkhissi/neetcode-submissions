public class Solution {
    public int CalPoints(string[] operations)
    {
        var result = new List<int>();
        foreach (var op in operations)
        {
            if (int.TryParse(op, out int num))
            {
                result.Add(num);
            }
            else if(op == "+")
            {
                result.Add(result.Last() + result[result.Count-2]);
            }
            else if(op == "D")
            {
                result.Add(result.Last() * 2);
            }
            else if(op == "C")
            {
                result.RemoveAt(result.Count - 1);
            }
        }

        return result.Sum();
    }
}
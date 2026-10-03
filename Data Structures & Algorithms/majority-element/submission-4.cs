public class Solution {
    public int MajorityElement(int[] nums)
    {
        var bits = new int[32];
        foreach(var x in nums)
        {
            var bit_rep = ToBinary(x);
            for(int i=0; i<32; i++)
            {
                if (bit_rep[i])
                {
                    bits[i]++;
                }
            }
        }

        var result = new bool[32];
        for(int i=0; i<32; i++)
        {
            if (bits[i] > nums.Length/2)
            {
                result[i] = true;
            }
        }
        return FromBinary(result); ;

    }

    int FromBinary(bool[] bits)
    {
        if (bits == null || bits.Length != 32)
            throw new ArgumentException("Array must contain exactly 32 bits.");

        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            if (bits[i])
                result |= 1 << i;
        }

        return result;
    }
    bool[] ToBinary(int value)
    {
        bool[] bits = new bool[32];

        for (int i = 0; i < 32; i++)
            bits[i] = (value & (1 << i)) != 0;

        return bits;
    }
}
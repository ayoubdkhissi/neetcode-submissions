public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var n = board.Length;

        char[][] cols = Enumerable.Range(0, 9)
        .Select(_ => new char[9])
        .ToArray();

        for (int i =0; i<board.Length; i++)
        {
            if (!CheckArray(board[i]))
                return false;
            for(int j=0; j<n; j++)
            {
                cols[i][j] = board[j][i];
            }
        }

        for(int i=0; i<n; i++)
        {
            if (!CheckArray(cols[i]))
                return false;
        }

        for(int i=0; i<9; i+=3)
        {
            for(int j=0; j<9; j+=3)
            {
                var subMatrix = board
                    .Skip(i)
                    .Take(3)
                    .Select(row => row.Skip(j).Take(3).ToArray())
                    .ToArray();

                if (!CheckMatrix(subMatrix))
                    return false;
            }
        }

        return true;

    }


    static bool CheckArray(char[] arr)
    {
        var set = new HashSet<char>();

        foreach(var c in arr)
        {
            if (c != '.' && set.Contains(c))
                return false;
            set.Add(c);
        }
        return true;
    }
    static bool CheckMatrix(char[][] matrix)
    {
        var set = new HashSet<char>();

        for(int i=0; i < matrix.Length; i++)
        {
            for(int j=0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != '.' && set.Contains(matrix[i][j]))
                    return false;
                set.Add(matrix[i][j]);
            }
        }

        return true;
    }
}

public class NumMatrix
{
	private int[][] PreFixSumMatrix { get; set; }

	public NumMatrix(int[][] matrix)
	{
		var n = matrix.Length;
		var m = matrix[0].Length;
		PreFixSumMatrix = matrix;

		for(int i=1; i<n; i++)
		{
			PreFixSumMatrix[i][0] += PreFixSumMatrix[i - 1][0];
		}
		for(int j=1; j<m; j++)
		{
			PreFixSumMatrix[0][j] += PreFixSumMatrix[0][j - 1];
		}

		for (int i = 1; i < n; i++)
		{
			for(int j = 1; j < m; j++)
			{
				PreFixSumMatrix[i][j] += PreFixSumMatrix[i - 1][j]
					   + PreFixSumMatrix[i][j - 1]
					   - PreFixSumMatrix[i - 1][j - 1];
			}
		}
	}

	public int SumRegion(int row1, int col1, int row2, int col2)
	{
		int result = PreFixSumMatrix[row2][col2];

		if (row1 > 0)
			result -= PreFixSumMatrix[row1 - 1][col2];

		if (col1 > 0)
			result -= PreFixSumMatrix[row2][col1 - 1];

		if (row1 > 0 && col1 > 0)
			result += PreFixSumMatrix[row1 - 1][col1 - 1];

		return result;
	}
}


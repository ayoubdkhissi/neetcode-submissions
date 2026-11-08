public class NumMatrix
{
	private int[][] PreFixSumMatrix { get; set; }

	public NumMatrix(int[][] matrix)
	{
		var n = matrix.Length;
		var m = matrix[0].Length;
		PreFixSumMatrix = matrix;

		for (int i = 0; i < n; i++)
		{
			PreFixSumMatrix[i][0] = PreFixSumMatrix[i][0];
			for(int j = 1; j < m; j++)
			{
				PreFixSumMatrix[i][j] = PreFixSumMatrix[i][j] + PreFixSumMatrix[i][j - 1];
			}
		}
	}

	public int SumRegion(int row1, int col1, int row2, int col2)
	{
		var sum = 0;

		for(int i = row1; i<=row2; i++)
		{
			sum += PreFixSumMatrix[i][col2] - (col1 == 0 ? 0 : PreFixSumMatrix[i][col1-1]);
		}

		return sum;
	}
}


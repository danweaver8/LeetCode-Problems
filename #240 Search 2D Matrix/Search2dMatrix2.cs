public static bool SearchMatrix(int[,] matrix, int target) {
	 if (matrix == null || matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1)
			return false;
	int row = 0;
	int column = matrix.GetLength(1)-1;

	while(column>=0 && row <=matrix.GetLength(0)-1)
	{
		if (target == matrix[row, column])
			return true;
		else if (target < matrix[row, column])
			column--;
		else if (target > matrix[row, column])
			row++;
	}
	return false;
}
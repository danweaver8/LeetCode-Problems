 public static int NumIslands(char[,] grid) {
	int total = 0;
	for(int i =0; i<grid.GetLength(0);i++) {
			for(int j=0;j<grid.GetLength(1); j++){
				if(grid[i,j]=='1'){
					total++;
					dfs(grid,i,j);
				}
			}
		}
	return total;
}

 public static void dfs(char[,] grid, int row, int col){
	if(row<0||row==grid.GetLength(0)||col<0||col==grid.GetLength(1)||grid[row,col]!='1')
		return;

	grid[row,col]='2';
	dfs(grid,row-1,col);
	dfs(grid,row+1,col);
	dfs(grid,row,col-1);
	dfs(grid,row,col+1);
}
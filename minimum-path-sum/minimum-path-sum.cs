public class Solution {
    public int MinPathSum(int[][] grid) 
    {
        if(grid == null || grid.Length == 0) return 0;
        
        int m = grid.Length;
        int n = grid[0].Length;
        
        
        
        for(int i = 1 ; i < m ; i++)
        {
            grid[i][0] += grid[i-1][0];
        }
        for(int i = 1 ; i < n ; i++)
        {
            grid[0][i] += grid[0][i-1];
        }
        
        for(int i = 1 ; i < grid.Length ; i++)
        {
            for(int j = 1 ; j < grid[0].Length ; j++)
            {
                grid[i][j] += Math.Min(grid[i-1][j], grid[i][j-1]);
            }
        }     
        return grid[m-1][n-1];
        
    }
}
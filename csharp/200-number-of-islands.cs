public class Solution {
    public int NumIslands(char[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var visited = new HashSet<(int, int)>();
        var islands = 0;

        void dfs(int row, int col, char[][] grid) {
            if (row < 0 || row >= rows || col < 0 || col >= cols) {
                return;
            }
            if (visited.Contains((row, col)) || grid[row][col] == '0') {
                return;
            }

            visited.Add((row, col));

            dfs(row + 1, col, grid);
            dfs(row - 1, col, grid);
            dfs(row, col + 1, grid);
            dfs(row, col - 1, grid);
        }

        for(var row = 0; row < rows; row++) {
            for(var col = 0; col < cols; col++) {
                if (!visited.Contains((row, col)) && grid[row][col] == '1') {
                    islands++;
                    dfs(row, col, grid);
                }
            }
        }
        return islands;
    }
}
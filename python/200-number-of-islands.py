class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        if not grid:
            return 0
        
        rows, cols = len(grid), len(grid[0])
        visit = set()
        islands = 0
        
        def bfs(row: int, col: int) -> None:
            q = deque()
            visit.add((row, col))
            q.append((row, col))

            while q:
                r, c = q.popleft()
                directions = [[1, 0], [-1, 0], [0, 1], [0, -1]]

                for dr, dc in directions:
                    if ((r + dr) in range(rows) and
                        (c + dc) in range(cols) and
                        grid[r + dr][c + dc] == '1' and
                        (r + dr, c + dc) not in visit):
                        q.append((r + dr, c + dc))
                        visit.add((r + dr, c + dc))
        for row in range(rows):
            for col in range(cols):
                if grid[row][col] == '1' and (row, col) not in visit:
                    bfs(row, col)
                    islands += 1
        return islands
        
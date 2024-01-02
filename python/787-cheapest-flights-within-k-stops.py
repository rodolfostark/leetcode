class Solution:
    def findCheapestPrice(self, n: int, flights: List[List[int]], src: int, dst: int, k: int) -> int:
        # Bellman-Ford algorithm
        prices = [float('inf')] * n
        prices[src] = 0

        for i in range(k + 1):
            temp_prices = prices.copy()
            # s -> src, d -> dst, p -> price
            for s, d, p in flights:
                if prices[s] == float('inf'):
                    continue
                if prices[s] + p < temp_prices[d]:
                    temp_prices[d] = prices[s] + p
            prices = temp_prices
        return -1 if prices[dst] == float('inf') else prices[dst]

        
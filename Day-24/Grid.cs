namespace Day_24
{
    public class Grid
    {
        public IReadOnlyCollection<Hexagon> Hexagons { get => _grid.Values; }

        private readonly Dictionary<HexagonalPosition, Hexagon> _grid = new();
        public Hexagon FromPosition(HexagonalPosition hexagonalPosition)
        {
            if (!_grid.ContainsKey(hexagonalPosition))
                _grid.Add(hexagonalPosition, new Hexagon(hexagonalPosition));
            
            return _grid[hexagonalPosition];
        }
    }
}
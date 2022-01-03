namespace Day_24
{
    public class Grid
    {
        public IReadOnlyCollection<Hexagon> Hexagons { get => _grid.Values; }

        private readonly Dictionary<HexagonalPosition, Hexagon> _grid = new();

        public Grid(int prefillSize = 142)
        {
            for (var xIndex = prefillSize / -2; xIndex < prefillSize / 2; xIndex++)
                for (var yIndex = prefillSize / -2; yIndex < prefillSize / 2; yIndex++)
                {
                    var hexagonalPosition = new HexagonalPosition(xIndex, yIndex);
                    _grid.Add(hexagonalPosition, new Hexagon(hexagonalPosition));
                }
        }

        public Hexagon FromPosition(HexagonalPosition hexagonalPosition)
        {
            if (!_grid.ContainsKey(hexagonalPosition))
                _grid.Add(hexagonalPosition, new Hexagon(hexagonalPosition));

            return _grid[hexagonalPosition];
        }

        public Hexagon[] GetNeighbours(Hexagon hexagon)
        {
            return GetNeighbours(hexagon.HexagonalPosition);
        }

        public Hexagon[] GetNeighbours(HexagonalPosition hexagonalPosition)
        {
            return new[]
            {
                FromPosition(hexagonalPosition.Shift(HexDirection.East)),
                FromPosition(hexagonalPosition.Shift(HexDirection.SouthEast)),
                FromPosition(hexagonalPosition.Shift(HexDirection.SouthWest)),
                FromPosition(hexagonalPosition.Shift(HexDirection.West)),
                FromPosition(hexagonalPosition.Shift(HexDirection.NorthWest)),
                FromPosition(hexagonalPosition.Shift(HexDirection.NorthEast)),
            };
        }
    }
}
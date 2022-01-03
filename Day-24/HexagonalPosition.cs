namespace Day_24
{
    public readonly record struct HexagonalPosition(int X, int Y)
    {
        public HexagonalPosition Shift(int x, int y)
        {
            return new HexagonalPosition(X + x, Y + y);
        }

        public HexagonalPosition Shift(HexDirection hexDirection)
        {
            return hexDirection switch
            {
                HexDirection.East => Shift(1, 0),
                HexDirection.West => Shift(-1, 0),
                HexDirection.SouthEast => Shift(1, 1),
                HexDirection.SouthWest => Shift(0, 1),
                HexDirection.NorthEast => Shift(0, -1),
                HexDirection.NorthWest => Shift(-1, -1),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
namespace Day_24
{
    public readonly record struct HexagonalPosition(int X, int Y)
    {
        public HexagonalPosition Shift(int x, int y)
        {
            return new HexagonalPosition(X + x, Y + y);
        }
    }
}
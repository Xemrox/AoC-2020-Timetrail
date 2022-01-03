namespace Day_24
{
    public class Hexagon
    {
        public State State { get; set; } = State.White;
        public HexagonalPosition HexagonalPosition { get; init; }

        public Hexagon(HexagonalPosition hexagonalPosition)
        {
            HexagonalPosition = hexagonalPosition;
        }

        public void Flip()
        {
            State = State switch
            {
                State.White => State.Black,
                State.Black => State.White,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
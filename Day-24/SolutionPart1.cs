using Xemrox.Shared;

namespace Day_24
{
    public class SolutionPart1 : IPuzzleSolution<int, HexagonalPosition>
    {
        public Hexagon Reference { get; init; } = new(new());

        public HexagonalPosition PuzzleTransformation(string line)
        {
            var directions = new List<HexDirection>();
            for (var index = 0; index < line.Length; index++)
            {
                switch (line[index])
                {
                    case 'e':
                        directions.Add(HexDirection.East);
                        break;
                    case 'w':
                        directions.Add(HexDirection.West);
                        break;
                    case 's':
                        {
                            switch (line[index + 1])
                            {
                                case 'e':
                                    directions.Add(HexDirection.SouthEast);
                                    break;
                                case 'w':
                                    directions.Add(HexDirection.SouthWest);
                                    break;
                            }
                            index++;
                            break;
                        }
                    case 'n':
                        {
                            switch (line[index + 1])
                            {
                                case 'e':
                                    directions.Add(HexDirection.NorthEast);
                                    break;
                                case 'w':
                                    directions.Add(HexDirection.NorthWest);
                                    break;
                                default:
                                    throw new NotSupportedException();
                            }
                            index++;
                            break;
                        }

                    default:
                        throw new NotSupportedException();
                }
            }

            var currentPosition = new HexagonalPosition();

            foreach (var direction in directions)
            {
                currentPosition = direction switch
                {
                    HexDirection.East => currentPosition.Shift(1, 0),
                    HexDirection.West => currentPosition.Shift(-1, 0),
                    HexDirection.SouthEast => currentPosition.Shift(1, 1),
                    HexDirection.SouthWest => currentPosition.Shift(0, 1),
                    HexDirection.NorthEast => currentPosition.Shift(0, -1),
                    HexDirection.NorthWest => currentPosition.Shift(-1, -1),
                    _ => throw new NotImplementedException(),
                };
            }

            return currentPosition;
        }

        public int SolvePuzzle(Puzzle<HexagonalPosition> puzzle)
        {
            var grid = new Grid();
            foreach (var position in puzzle.Value)
            {
                var tile = grid.FromPosition(position);
                tile.Flip();
            }

            return grid.Hexagons.Where(x => x.State == State.Black).Count();
        }
    }
}
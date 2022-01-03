using System.Diagnostics;
using Xemrox.Shared;

namespace Day_24
{
    public class SolutionPart2 : SolutionPart1
    {
        public override int SolvePuzzle(Puzzle<HexagonalPosition> puzzle)
        {
            var grid = new Grid();
            foreach (var position in puzzle.Value)
            {
                var tile = grid.FromPosition(position);
                tile.Flip();
            }

            for (var iteration = 0; iteration < 100; iteration++)
            {
                ApplyRules(grid);
                Debug.WriteLine("Day {0}: {1}", iteration, grid.Hexagons.Where(x => x.State == State.Black).Count());
            }

            return grid.Hexagons.Where(x => x.State == State.Black).Count();
        }

        private static void ApplyRules(Grid grid)
        {
            var observableTiles = grid.Hexagons.ToArray();
            var flipTiles = new List<Hexagon>();
            foreach (var tile in observableTiles)
            {
                var neighbours = grid.GetNeighbours(tile);

                var blackNeighbours = neighbours.Where(x => x.State == State.Black).Count();
                switch (tile.State)
                {
                    case State.Black:
                        if (blackNeighbours == 0 || blackNeighbours > 2)
                            flipTiles.Add(tile);
                        break;
                    case State.White:
                        if (blackNeighbours == 2)
                            flipTiles.Add(tile);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            foreach (var tile in flipTiles)
            {
                tile.Flip();
            }
        }
    }
}
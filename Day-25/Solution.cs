using Xemrox.Shared;

namespace Day_25
{
    public class Solution : IPuzzleSolution<Day26Solution, Day25Puzzle>
    {
        public Day25Puzzle PuzzleTransformation(string line)
        {
            return new Day25Puzzle(int.Parse(line));
        }

        public Day26Solution SolvePuzzle(Puzzle<Day25Puzzle> puzzle)
        {
            throw new NotImplementedException();
        }
    }
}
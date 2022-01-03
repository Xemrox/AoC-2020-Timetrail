using System.Linq;
using Xemrox.Shared;
using Xunit;

namespace Day_25.Test
{
    public class SolutionTests
    {
        [Fact]
        public void Demo()
        {
            var solver = new Solution();
            var inputData = PuzzleLoader.LoadInputFile("./input/demo_25.txt", solver.PuzzleTransformation);

            var cardCode = inputData.Value.First();
            var doorCode = inputData.Value.Last();

            Assert.Equal(cardCode.PublicCode, Solution.TransformSubjectNumber(7, 8));
            Assert.Equal(doorCode.PublicCode, Solution.TransformSubjectNumber(7, 11));

            var solution = solver.SolvePuzzle(inputData);

            Assert.Equal(8, solution.CardLoopSize);
            Assert.Equal(11, solution.DoorLoopSize);

            Assert.Equal(14897079, solution.CardDoorEncryptionKey);
            Assert.Equal(14897079, solution.DoorCardEncryptionKey);
        }

        [Fact]
        public void Xemrox()
        {
            var solver = new Solution();
            var inputData = PuzzleLoader.LoadInputFile("./input/xemrox_25.txt", solver.PuzzleTransformation);

            var cardCode = inputData.Value.First();
            var doorCode = inputData.Value.Last();

            var solution = solver.SolvePuzzle(inputData);

            Assert.Equal(7731677, solution.CardLoopSize);
            Assert.Equal(16473833, solution.DoorLoopSize);

            Assert.Equal(3803729, solution.CardDoorEncryptionKey);
            Assert.Equal(3803729, solution.DoorCardEncryptionKey);
        }
    }
}
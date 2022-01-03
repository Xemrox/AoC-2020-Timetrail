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
            var inputData = PuzzleLoader.LoadInputFile("./demo_25.txt", solver.PuzzleTransformation);

            var solution = solver.SolvePuzzle(inputData);

            Assert.Equal(8, solution.CardLoopSize);
            Assert.Equal(7, solution.CardSubjectCode);
            Assert.Equal(11, solution.DoorLoopSize);
            Assert.Equal(7, solution.DoorSubjectCode);

            Assert.Equal(14897079, solution.EncryptionKey);
        }
    }
}
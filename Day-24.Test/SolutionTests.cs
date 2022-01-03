using Xemrox.Shared;
using Xunit;

namespace Day_24.Test
{
    public class SolutionTests
    {
        [Fact]
        public void PositionTests()
        {
            var solver = new SolutionPart1();
            var position = solver.PuzzleTransformation("nwwswee");
            Assert.Equal(0, position.X);
            Assert.Equal(0, position.Y);
        }

        [Fact]
        public void Demo()
        {
            var solver = new SolutionPart1();
            var inputData = PuzzleLoader.LoadInputFile("./input/demo_24.txt", solver.PuzzleTransformation);

            var blackHexes = solver.SolvePuzzle(inputData);
            Assert.Equal(10, blackHexes);
        }

        [Fact]
        public void DemoPart2()
        {
            var solver = new SolutionPart2();
            var inputData = PuzzleLoader.LoadInputFile("./input/demo_24.txt", solver.PuzzleTransformation);

            var blackHexes = solver.SolvePuzzle(inputData);
            Assert.Equal(2208, blackHexes);
        }

        [Fact]
        public void Xemrox()
        {
            var solver = new SolutionPart1();
            var inputData = PuzzleLoader.LoadInputFile("./input/xemrox_24.txt", solver.PuzzleTransformation);

            var blackHexes = solver.SolvePuzzle(inputData);
            Assert.Equal(339, blackHexes);
        }

        [Fact]
        public void XemroxPart2()
        {
            var solver = new SolutionPart2();
            var inputData = PuzzleLoader.LoadInputFile("./input/xemrox_24.txt", solver.PuzzleTransformation);

            var blackHexes = solver.SolvePuzzle(inputData);
            Assert.Equal(3794, blackHexes);
        }
    }
}
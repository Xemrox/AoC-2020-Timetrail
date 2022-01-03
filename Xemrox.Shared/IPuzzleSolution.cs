namespace Xemrox.Shared
{
    public interface IPuzzleSolution<TSolution, TInput>
    {
        TInput PuzzleTransformation(string line);

        TSolution SolvePuzzle(Puzzle<TInput> puzzle);
    }
}

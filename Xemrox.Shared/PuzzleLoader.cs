using System;
using System.IO;
using System.Linq;

namespace Xemrox.Shared;
public static class PuzzleLoader
{
    /// <summary>
    /// Loads a well defined puzzle input file <paramref name="fileName"/> and transforms it according to <paramref name="contentTransformation"/>
    /// </summary>
    /// <typeparam name="T">Type of puzzle input</typeparam>
    /// <param name="fileName">Target filename</param>
    /// <param name="contentTransformation">Content transformation function</param>
    /// <returns>Instance of <see cref="Puzzle{T}" /></returns>
    /// <exception cref="FileNotFoundException"></exception>
    public static Puzzle<T> LoadInputFile<T>(string fileName, Func<string, T> contentTransformation)
    {
        if (!File.Exists(fileName))
            throw new FileNotFoundException(fileName);

        var shortFileName = Path.GetFileNameWithoutExtension(fileName);
        var puzzleName = shortFileName
            .Split('_')
            .First();

        var fileLines = File.ReadAllLines(fileName, System.Text.Encoding.UTF8);
        var transformedContent = fileLines
            .Select(contentTransformation)
            .ToArray();

        return new Puzzle<T>(
            puzzleName,
            transformedContent
        );
    }

    /// <summary>
    /// Loads all lines of a puzzle file as raw strings
    /// </summary>
    /// <param name="fileName">The file to load</param>
    /// <returns>Instance of <see cref="Puzzle{T}" /> whose generic type argument is <see cref="string"/> </returns>
    public static Puzzle<string> LoadInputFile(string fileName)
    {
        return LoadInputFile(fileName, line => line);
    }
}

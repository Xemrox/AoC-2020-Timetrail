using System.Linq;
using Xemrox.Shared;

namespace Day_25
{
    public class Solution : IPuzzleSolution<Day26Solution, Day25Puzzle>
    {
        private const ulong DIVISOR = 20201227UL;

        public Day25Puzzle PuzzleTransformation(string line)
        {
            return new Day25Puzzle(int.Parse(line));
        }

        public Day26Solution SolvePuzzle(Puzzle<Day25Puzzle> puzzle)
        {
            var cardCode = puzzle.Value.First();
            var doorCode = puzzle.Value.Last();

            var cardLoopSize = SearchForLoop(cardCode.PublicCode);
            var doorLoopSize = SearchForLoop(doorCode.PublicCode);

            var cardDoorEncryptionKey = TransformSubjectNumber(cardCode.PublicCode, doorLoopSize);
            var doorCardEncryptionKey = TransformSubjectNumber(doorCode.PublicCode, cardLoopSize);

            return new Day26Solution()
            {
                CardLoopSize = cardLoopSize,
                DoorLoopSize = doorLoopSize,

                CardDoorEncryptionKey = cardDoorEncryptionKey,
                DoorCardEncryptionKey = doorCardEncryptionKey,
            };
        }

        public static int SearchForLoop(int code)
        {
            var currentValue = 1UL;
            var loopCount = 0;

            while ((int)currentValue != code) {
                currentValue = TransformSubjectNumberStep(currentValue);
                loopCount++;
            }
            return loopCount;
        }

        public static int TransformSubjectNumber(int subjectNumber, int loopSize)
        {
            ulong currentNumber = 1;

            for (var loopCount = 0; loopCount < loopSize; loopCount++)
            {
                //currentNumber = TransformSubjectNumberStep(currentNumber, (ulong)subjectNumber);
                currentNumber *= (ulong)subjectNumber;
                currentNumber %= DIVISOR;
            }

            return (int)currentNumber;
        }

        public static ulong TransformSubjectNumberStep(ulong currentSubject)
        {
            return currentSubject * 7UL % DIVISOR;
        }
    }
}
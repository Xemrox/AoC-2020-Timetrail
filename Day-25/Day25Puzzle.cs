namespace Day_25
{
    public readonly struct Day25Puzzle
    {
        public int PublicCode { get; init; }

        public Day25Puzzle(int publicCode)
        {
            PublicCode = publicCode;
        }
    }

    public readonly struct Day26Solution
    {
        public int DoorSubjectCode { get; init; }
        public int DoorLoopSize { get; init; }

        public int CardSubjectCode { get; init; }
        public int CardLoopSize { get; init; }

        public int EncryptionKey { get; init; }
    }
}
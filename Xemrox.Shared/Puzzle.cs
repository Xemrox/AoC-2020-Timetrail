namespace Xemrox.Shared;

public readonly struct Puzzle<T>
{
    public readonly string Name { get; init; }
    public readonly T[] Value { get; init; }

    public Puzzle(string name, T[] value)
    {
        Name = name;
        Value = value;
    }
}

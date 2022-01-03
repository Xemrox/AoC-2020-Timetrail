namespace Xemrox.Shared;

public record class Puzzle<T>
{
    public string Name { get; init; }
    public T[] Value { get; init; }

    public Puzzle(string name, T[] value)
    {
        Name = name;
        Value = value;
    }
}

namespace Bookshelf;

public class Book
{
    public string Name { get; }

    public bool Anniversary { get; set; }

    public Book(string name)
    {
        Name = name;
    }

    public Book(string name, bool anniversary) : this(name)
    {
        Anniversary = anniversary;
    }

    private bool Equals(Book other)
    {
        return Name == other.Name && Anniversary == other.Anniversary;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Book)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Anniversary);
    }
}
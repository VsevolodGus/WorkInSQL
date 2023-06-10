namespace Kursach.DAL;

[AttributeUsage(AttributeTargets.Property)]
public class ColumnHeadrAttribute : Attribute
{
    public ColumnHeadrAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; init; }
}
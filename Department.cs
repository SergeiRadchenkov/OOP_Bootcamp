public class Department
{
    public int Id;
    public string Title;

    public Department(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public override string ToString()
    {
        return $"title: {Title} id: {Id}";
    }
}
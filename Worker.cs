public class Worker
{
    public int Id;
    public int DepId;
    public int Age;
    public string FullName;
    public int Salary;
    private string v1;
    private int v2;
    private int v3;

    public Worker(string v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public Worker(int id, int depId, int age, string fullName, int salary)
    {
        this.Id = id;
        this.DepId = depId;
        this.Age = age;
        this.FullName = fullName;
        this.Salary = salary;
    }

    public override string ToString()
    {
        return $"id: {this.Id} Full name: {this.FullName} age: {this.Age} salary: {this.Salary} dep id: {this.DepId}";
    }
}
public class DataBase
{
    public List<Department> DepTable { get; set; }
    public List<Worker> WorkerTable { get; set; }

    public DataBase()
    {
        DepTable = new List<Department>();
        WorkerTable = new List<Worker>();
    }

    public void AppendWorker(Worker worker)
    {
        WorkerTable.Add(worker);
    }

    public void AppendDep(Department dep)
    {
        DepTable.Add(dep);
    }

    public string SelectAllDep()
    {
        string output = "";
        foreach (var d in DepTable)
        {
            output += $"{d.Title}\n";
        }
        return output;
    }

    public string SelectAllWorker()
    {
        string output = "";
        foreach (var w in WorkerTable)
        {
            output += $"{w.FullName} {w.Age}\n";
        }
        return output;
    }

    public List<Tuple<string, int, string>> Report()
    {
        var rep = new List<Tuple<string, int, string>>();
        foreach (var w in WorkerTable)
        {
            var departmentTitle = DepTable[w.DepId].Title;
            rep.Add(new Tuple<string, int, string>(w.FullName, w.Age, departmentTitle));
        }
        return rep;
    }
}
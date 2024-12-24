class Program
{
    static void Main(string[] args)
    {
        // Создание департаментов
        Department dep1 = new Department(0, "Информационные технологии");
        Department dep2 = new Department(1, "Отдел кадров");
        Department dep3 = new Department(2, "Бухгалтерия");

        // Создание сотрудников
        Worker worker1 = new Worker(1, 2, 23, "Мария Ивановна", 1234);
        Worker worker2 = new Worker(2, 0, 26, "Мария Степановна", 3456);
        Worker worker3 = new Worker(3, 1, 33, "Василий Петрович", 5432);
        Worker worker4 = new Worker(4, 0, 33, "Игнат Петрович", 5432);

        // Создание базы данных и добавление данных
        DataBase db = new DataBase();
        db.AppendWorker(worker1);
        db.AppendWorker(worker2);
        db.AppendWorker(worker3);
        db.AppendWorker(worker4);

        db.AppendDep(dep1);
        db.AppendDep(dep2);
        db.AppendDep(dep3);

        // Вывод всех департаментов
        Console.WriteLine(db.SelectAllDep());
        Console.WriteLine("===================");
        
        // Вывод всех сотрудников
        Console.WriteLine(db.SelectAllWorker());
        Console.WriteLine("===================");
        
        Console.WriteLine("done");
    }
}

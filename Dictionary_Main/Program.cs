
    Employee[] employees =
        {
        new Employee ("CEO", "Gwyn", 95,200),
        new Employee ("Manager", "Joe", 100,200),
        new Employee ("HR", "George", 85,200),
        new Employee ("Secretary", "Harriet", 25,200),
        new Employee ("Lead Developer", "Mando", 45,200),
        new Employee ("Intern", "Sam", 80,200)

    };

    Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

    foreach (Employee emp in employees)
    {
        employeesDirectory.Add(emp.Role, emp);
    }

    string? consoleInput = Console.ReadLine(); //allowed to be null, caught at line 40


    if (consoleInput != null)
    {
        string key = consoleInput;

        if (employeesDirectory.ContainsKey(key))
        {
            Employee empl = employeesDirectory[key];
            Console.WriteLine($"{empl.Name} | {empl.Age} | {empl.Salary}");
        }
        else
        {
            Console.WriteLine("No employee found", key);
        }


        Console.Read();
    }
    else
    {
        Console.WriteLine("Value cannot be Null");
    }


public class Employee {
    public string Role { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public float Rate { get; set; }

    public float Salary
    {
        get
        {
            return Rate * 8 * 5 * 4 * 12;
        }
    }

    public Employee(string role, string name, int age, float rate)
    {
        this.Role = role;
        this.Name = name;
        this.Age = age;
        this.Rate = rate;
    }
}


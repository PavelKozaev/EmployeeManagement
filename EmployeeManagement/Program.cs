using EmployeeManagement.Models;
using EmployeeManagement.Repositories;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Аргументы не предоставлены.");
            return;
        }

        var repository = new EmployeeRepository("employees.json");

        switch(args[0])
        {
            case "-add":
                HandleAdd(args, repository);
                break;
            case "-update":
                HandleUpdate(args, repository);
                break;
            case "-get":
                HandleGet(args, repository);
                break;
            case "-delete":
                HandleDelete(args, repository);
                break;
            case "-getall":
                HandleGetAll(repository);
                break;
            default:
                Console.WriteLine("Неизвестная команда.");
                break;
        }
    }

    private static void HandleAdd(string[] args, EmployeeRepository repository)
    {
        var firstName = GetArgumentValue(args, "FirstName");
        var lastName = GetArgumentValue(args, "LastName");
        var salary = decimal.Parse(GetArgumentValue(args, "Salary"), System.Globalization.CultureInfo.InvariantCulture);

        var employee = new Employee
        {
            FirstName = firstName,
            LastName = lastName,
            SalaryPerHour = salary
        };

        repository.AddEmployee(employee);
        Console.WriteLine("Сотрудник успешно добавлен.");
    }


    private static void HandleUpdate(string[] args, EmployeeRepository repository)
    {
        var id = int.Parse(GetArgumentValue(args, "Id"));
        var firstName = GetArgumentValue(args, "FirstName");
        var lastName = GetArgumentValue(args, "LastName");
        var salary = GetArgumentValue(args, "Salary") != null ? (decimal?)decimal.Parse(GetArgumentValue(args, "Salary")) : null;

        repository.UpdateEmployee(id, firstName, lastName, salary);
        Console.WriteLine("Данные сотрудника успешно обновлены.");
    }

    private static void HandleGet(string[] args, EmployeeRepository repository)
    {
        var id = int.Parse(GetArgumentValue(args, "Id"));
        var employee = repository.GetEmployee(id);
        if (employee == null)
        {
            Console.WriteLine($"Ошибка: сотрудник с идентификатором {id} не найден.");
            return;
        }
        Console.WriteLine($"Id = {employee.Id}, FirstName = {employee.FirstName}, LastName = {employee.LastName}, SalaryPerHour = {employee.SalaryPerHour}");
    }

    private static void HandleDelete(string[] args, EmployeeRepository repository)
    {
        var id = int.Parse(GetArgumentValue(args, "Id"));
        repository.DeleteEmployee(id);
        Console.WriteLine("Сотрудник успешно удален.");
    }

    private static void HandleGetAll(EmployeeRepository repository)
    {
        var employees = repository.GetAllEmployees();
        foreach (var employee in employees)
        {
            Console.WriteLine($"Id = {employee.Id}, FirstName = {employee.FirstName}, LastName = {employee.LastName}, SalaryPerHour = {employee.SalaryPerHour}");
        }
    }

    private static string GetArgumentValue(string[] args, string key)
    {
        var argument = Array.Find(args, arg => arg.StartsWith($"{key}:"));
        return argument?.Split(':')[1];
    }
}
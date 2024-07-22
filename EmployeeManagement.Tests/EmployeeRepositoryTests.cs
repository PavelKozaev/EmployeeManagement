using EmployeeManagement.Repositories;
using EmployeeManagement.Models;

[TestFixture]
public class EmployeeRepositoryTests
{
    private const string FilePath = "test_employees.json";
    private EmployeeRepository _repository;

    [SetUp]
    public void SetUp()
    {
        _repository = new EmployeeRepository(FilePath);
    }

    [TearDown]
    public void TearDown()
    {
        if (File.Exists(FilePath))
        {
            File.Delete(FilePath);
        }
    }

    [Test]
    public void AddEmployee_ShouldAddEmployee()
    {
        var employee = new Employee
        {
            FirstName = "John",
            LastName = "Doe",
            SalaryPerHour = 100.50m
        };

        _repository.AddEmployee(employee);
        var employees = _repository.GetAllEmployees();

        Assert.AreEqual(1, employees.Count);
        Assert.AreEqual("John", employees[0].FirstName);
        Assert.AreEqual("Doe", employees[0].LastName);
        Assert.AreEqual(100.50m, employees[0].SalaryPerHour);
    }
}

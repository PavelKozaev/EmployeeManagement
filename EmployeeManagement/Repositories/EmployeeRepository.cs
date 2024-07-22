using EmployeeManagement.Models;
using Newtonsoft.Json;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository
    {
        private readonly string _filePath;

        public EmployeeRepository(string filePath) 
        {
            _filePath = filePath;
        }

        private List<Employee> LoadEmployees()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Employee>();
            }

            var jsonData = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Employee>>(jsonData) ?? new List<Employee>();
        }

        private void SaveEmployees(List<Employee> employees)
        {
            var jsonData = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);
        }

        public void AddEmployee(Employee employee)
        {
            var employees = LoadEmployees();
            employee.Id = employees.Any() ? employees.Max(e => e.Id) + 1 : 1;
            employees.Add(employee);
            SaveEmployees(employees);
        }

        public void UpdateEmployee(int id, string firstName, string lastName, decimal? salaryPerHour)
        {
            var employees = LoadEmployees();
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                Console.WriteLine($"Ошибка: сотрудник с идентификатором {id} не найден.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(firstName)) employee.FirstName = firstName;
            if (!string.IsNullOrWhiteSpace(lastName)) employee.LastName = lastName;
            if (salaryPerHour.HasValue) employee.SalaryPerHour = salaryPerHour.Value;

            SaveEmployees(employees);
        }

        public Employee GetEmployee(int id)
        {
            var employees = LoadEmployees();
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> GetAllEmployees()
        {
            return LoadEmployees();
        }

        public void DeleteEmployee(int id)
        {
            var employees = LoadEmployees();
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                Console.WriteLine($"Ошибка: сотрудник с идентификатором {id} не найден.");
                return;
            }

            employees.Remove(employee);
            SaveEmployees(employees);
        }
    }
}

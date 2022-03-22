using MyEmployees.Server.Models;

namespace MyEmployees.Client.Services
{
    public interface IEmployeeService
    {
        List<Employee> Employees { get; set; }
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<HttpResponseMessage> UpdateEmployee(Employee updatedEmployee);
    }
}

using MyEmployees.Server.Models;
using System.Net.Http.Json;

namespace MyEmployees.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public async Task<List<Employee>> GetEmployees()
        {
            Employees = await _httpClient.GetFromJsonAsync<List<Employee>>("/employees");
            return Employees;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await _httpClient.GetFromJsonAsync<Employee>($"/employee/{id}");
            return employee;
        }

        public async Task<HttpResponseMessage> UpdateEmployee(Employee updatedEmployee)
        {
            return await _httpClient.PutAsJsonAsync<Employee>($"/employee/{updatedEmployee.id}", updatedEmployee);
        }
    }
}

using EmployeeWeb.Api.Models;

namespace EmployeeWeb.Api.Services.Interfaces
{
    public interface IEmployeeService
    {
        //Create
        public void CreateEmployee(Employee employee);
        //Read
        public Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        //Update
        public void UpdateEmployee(Employee employee);
        //Delete
        public bool DeleteEmployee(int id);
    }
}

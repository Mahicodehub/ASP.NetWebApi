using EmployeeWeb.Api.Models;
using EmployeeWeb.Api.Services.Interfaces;

namespace EmployeeWeb.Api.Services
{
    public class EmployeeService:IEmployeeService
    {
        List<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Harry Potter" },
                new Employee() { Id = 2, Name = "Hermoine" },
                new Employee() { Id = 3, Name = "RuthorFord"}
            };
        }
        //Create
        public void CreateEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        //Read
        public Employee GetEmployee(int Id)
        {
            return _employees.Where(x => x.Id == Id).FirstOrDefault();
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }

        //Update
        public void UpdateEmployee(Employee employee)
        {
            var originalEmployee = GetEmployee(employee.Id);
            if (originalEmployee != null)
            {
                _employees.ForEach(item =>
                {
                    if (item.Id == employee.Id)
                    {
                        item.Name = employee.Name;
                    }
                });
            }
            else
            {
                _employees.Add(employee);
            }
        }

        //Delete

        public bool DeleteEmployee(int Id)
        {
            _employees.RemoveAt(Id);
           // _employees = _employees.Where(x => x.Id != Id).ToList();
            return true;
        }
    }
}

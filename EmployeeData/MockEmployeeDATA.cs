using CRUD_API.Models;

namespace CRUD_API.EmployeeData
{
    public class MockEmployeeDATA : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Priyanka Singhania"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Shaurya singh"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Suman singh"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Pinky gupta"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Divyansh Singh"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
           var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}

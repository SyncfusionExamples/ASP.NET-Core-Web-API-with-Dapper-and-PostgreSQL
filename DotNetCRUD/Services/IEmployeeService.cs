using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCRUD.Models;

namespace DotNetCRUD.Services;

public interface IEmployeeService
{
    Task<bool> CreateEmployee(Employee employee);
    Task<Employee> GetEmployee(int id);
    Task<List<Employee>> GetEmployeeList();
    Task<Employee> UpdateEmployee(Employee employee);
    Task<bool> DeleteEmployee(int key);
    
}
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data
{
    public interface IEmployeeService
    {
        Task<EmployeeModel[]> GetEmplyee();
        Task InsertEmployee(EmployeeModel employee);
    }
}
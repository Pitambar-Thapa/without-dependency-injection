using WithoutDependencyInjection.Models;

namespace WithoutDependencyInjection.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetById(int id);
    }
}

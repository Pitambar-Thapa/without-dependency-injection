using Microsoft.AspNetCore.Mvc;
using WithoutDependencyInjection.Repository;

namespace WithoutDependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public JsonResult Index()
        {
            //EmployeeRepository employeeRepository = new EmployeeRepository();
            return Json(employeeRepository.GetAll());
        }

        public JsonResult Details(int id)
        {
            //EmployeeRepository employeeRepository = new EmployeeRepository();
            return Json(employeeRepository.GetById(id));
        }
    }
}

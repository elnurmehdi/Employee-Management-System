using Emp.Manage.System.Database.DataBaseAccess;
using Emp.Manage.System.Database.Models;
using Emp.Manage.System.Migrations;
using Emp.Manage.System.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Employee = Emp.Manage.System.Database.Models.Employee;

namespace Emp.Manage.System.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
        #region Read
        public ActionResult List()
        {

            DataContext dataContext = new DataContext();

            var model = dataContext.Employees.Select(e => new ListViewModel(e.EmployeeCode, e.FirstName, e.LastName, e.FatherName)).ToList();

            return View(model);

        }
        #endregion


        #region Add
        [HttpGet("add", Name = "employee-add")]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost("add", Name = "employee")]
        public ActionResult Add(AddViewModel model)
        {
            DataContext dataContext = new DataContext();
            var employee = dataContext.Employees
              .Select(e => new AddViewModel(e.FirstName, e.LastName, e.FIN, e.Email, e.FatherName))
              .ToList();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            dataContext.Employees.Add(new Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                FIN = model.FIN,
                Email = model.Email,
                FatherName = model.FatherName,
                EmployeeCode = TableAutoIncrementEmployeeCode.RandomEmpCode
            });
            dataContext.SaveChanges();
            return View(model);
        }
        #endregion

        [HttpGet("update/{EmployeeCode}", Name = "employee-update")]
        public IActionResult Update(string employeeCode)
        {
            DataContext context = new DataContext();
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeCode == employeeCode);
            if (employee == null)
            {
                return NotFound();
            }

            return View( new UpdateViewModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                FatherName = employee.FatherName,
                Email = employee.Email,
               
            });
        }
        [HttpPost("update/{EmployeeCode}", Name = "employee-update")]
        public IActionResult Update(UpdateViewModel model)
        {
            DataContext context = new DataContext();
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeCode == model.EmployeeCode);
            if (employee == null)
            {
                return NotFound();
            }


            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.FatherName = model.FatherName;
            employee.Email = model.Email;
            employee.FIN = model.FIN;
            context.SaveChanges();
            return RedirectToAction(nameof(List));

        }




    }
}

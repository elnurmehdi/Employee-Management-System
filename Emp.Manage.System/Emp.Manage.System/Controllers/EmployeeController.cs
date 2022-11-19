using Microsoft.AspNetCore.Mvc;

namespace Emp.Manage.System.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult List()
        {
            return View();
        }
    }
}

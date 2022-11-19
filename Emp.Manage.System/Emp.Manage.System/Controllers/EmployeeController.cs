using Microsoft.AspNetCore.Mvc;

namespace Emp.Manage.System.Controllers
{
    public class EmployeeController : Controller
    {
        #region Read
        public ActionResult List()
        {


            return View();
        }
        #endregion 
    }
}

using ProjectCRM.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCRM.Data;

namespace ProjectCRM.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CustomerController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable <Customer> allCustomer = _db.a_user;
            return View(allCustomer);
        }
    }
}

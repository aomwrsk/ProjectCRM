using Microsoft.AspNetCore.Mvc;
using ProjectCRM.Data;
using System.Linq;

namespace ProjectCRM.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDBContext _db;

        public DashboardController(ApplicationDBContext db)
        {
            _db = db;
        }

        // ✅ View Dashboard
        public IActionResult Index()
        {
            return View();
        }

        // ✅ Endpoint ส่งข้อมูลยอดขายกลับไปให้ JS (เช่นใช้กับ Chart.js)
        [HttpGet]
        public IActionResult GetSalesData()
        {
            // ตัวอย่างจำลองข้อมูลจากฐานจริง
            var salesData = new[]
            {
                new { Month = "Jan", Total = 120000 },
                new { Month = "Feb", Total = 98000 },
                new { Month = "Mar", Total = 135000 },
                new { Month = "Apr", Total = 110000 },
                new { Month = "May", Total = 150000 },
                new { Month = "Jun", Total = 170000 }
            };

            return Json(salesData);
        }
    }
}

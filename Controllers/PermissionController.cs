using Microsoft.AspNetCore.Mvc;
using ProjectCRM.Data;
using ProjectCRM.Models;
using System.Linq;

namespace ProjectCRM.Controllers
{
    public class PermissionController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PermissionController(ApplicationDBContext db)
        {
            _db = db;
        }

        // ✅ แสดงรายชื่อลูกค้า
        public IActionResult Index()
        {
            var allCustomers = _db.a_user.ToList();
            return View(allCustomers);
        }

        // ✅ อัปเดตสถานะ Active
        [HttpPost]
        public IActionResult UpdateActive([FromBody] UpdateActiveRequest request)
        {
            if (request == null)
                return BadRequest("Invalid data");

            // 🔍 หา record ตาม staff_id และ username
            var customer = _db.a_user
                .FirstOrDefault(c => c.staff_id == request.StaffId && c.username == request.Username);

            if (customer == null)
                return NotFound("Customer not found");

            // ✅ แปลง Boolean เป็น CHAR(1)
            customer.active = request.IsActive ? "Y" : "N";

            _db.SaveChanges();

            return Ok(new { message = "Status updated successfully" });
        }
    }

    // ✅ DTO class สำหรับรับค่าจากฝั่ง client
    public class UpdateActiveRequest
    {
        public required string StaffId { get; set; }    // <-- เปลี่ยนเป็น string
        public required string Username { get; set; }
        public bool IsActive { get; set; }
    }
}

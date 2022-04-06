using BusinessObjectLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ApiLayer.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ProductDbContext _context;
        IAdminOperations _admin;
        public AdminController(ProductDbContext context, IAdminOperations admin)
        {
            _context = context;
            _admin = admin;

        }
        public IActionResult Get()
        {
            return new JsonResult("success");
        }
        [HttpPost]
        public IActionResult Post()
        {
            return new JsonResult("postr success");
        }
    }
}

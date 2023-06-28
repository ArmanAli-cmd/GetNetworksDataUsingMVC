using GetDataApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetDataApplication.Controllers
{
    public class NetworkController : Controller
    {
        private readonly ApplicationDbContext _db;
        public NetworkController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult GetNetworks()
        {

            List<Network> networks = _db.Networks.ToList();
            return View(networks);
        }
    }
}

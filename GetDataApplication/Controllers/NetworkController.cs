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
        public IActionResult Index()
        {

            List<Network> networks = _db.Networks.ToList();
            return View(networks);
        }
        public IActionResult Search(string searchInput)
        {
            var filteredData = _db.Networks.Where(item => item.SerialNumber.Contains(searchInput)).ToList();
            // Pass the filtered data to the view
            return View("Index", filteredData);
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gambit.Models;

namespace Gambit.Controllers
{
	public class MiStartupController : Controller
    {
        private readonly MiStartupContext _context;

        public MiStartupController(MiStartupContext context)
        {
            _context = context;
        }

		public async Task<IActionResult> Index()
		{
			return View(await _context.Category.Include(c => c.Startups).ToListAsync());
		}

		public IActionResult Details()
		{
			return View();
		}

		public IActionResult Dashboard()
		{
			return View();
		}
	}
}

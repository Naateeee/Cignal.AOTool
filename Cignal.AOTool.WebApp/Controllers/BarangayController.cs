using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Cignal.AOTool.WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Cignal.AOTool.WebApp.Controllers
{
    [Route("[controller]")]
    public class BarangayController : Controller
    {
        private readonly ILogger<BarangayController> _logger;
        private readonly ApplicationDbContext _context;
        public BarangayController(ILogger<BarangayController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var barangays = await _context.Barangays
                    .Include(c => c.City)
                    .ToListAsync();
            
            return View(barangays);
        }
    }
}
using GymMangementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymMangementSystem.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext dbContext;
        public PlanController(GymDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task <IActionResult> Index()
        {
            var Plans = await dbContext.Plans.ToListAsync();
            return View(Plans);
        }
    }
}

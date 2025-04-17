using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class ProjectController : Controller
    {
        ApplicationDbContext _context;
        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Project> projects = _context.Projects
                .Include(p => p.ProjectSkills)
                  .ThenInclude(ps => ps.Skill)
                .ToList();

            return View("AllProjects", projects);
        }
    }
}

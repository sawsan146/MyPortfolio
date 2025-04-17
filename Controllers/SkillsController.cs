using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class SkillsController : Controller
    {
        ApplicationDbContext _context;
        public SkillsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Skill> skills = _context.Skills
                    .Include(s => s.ProjectSkills)
                    .ThenInclude(ps => ps.Project)
                    .ToList();
            return View("AllSkills", skills);
        }

    }
}

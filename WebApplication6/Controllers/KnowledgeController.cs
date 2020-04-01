using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System.Threading.Tasks;
using System;
using System.Linq;


namespace DIMON_APP.Controllers
{
    public class KnowledgeController : Controller
    {
        private PGKnowledgeDBContext _context;
        public KnowledgeController(PGKnowledgeDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddProblem(Problem problem)
        {
            try
            {
                _context.dm_problem.Add(problem);
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddReason(Reason reason)
        {
            try
            {
                _context.dm_reason.Add(reason);
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddSolution(Solution solution)
        {
            try
            {
                _context.dm_solution.Add(solution);
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetApparatusProblems(int apId)
        {
            return Json(_context.dm_problem.Where(x => x.ap_id == apId).ToList());
        }

        [HttpGet]
        public IActionResult GetProblemReasons(int prId)
        {
            return Json(_context.dm_reason.Where(x => x.pr_id == prId).ToList());
        }

        [HttpGet]
        public IActionResult GetSolutionByReason(int rsId)
        {
            return Json(_context.dm_solution.Where(x => x.rs_id == rsId).ToList());
        }



    }
}
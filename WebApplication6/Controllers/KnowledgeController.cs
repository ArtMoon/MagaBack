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
                var pr = _context.dm_problem.Find(problem.pr_id);
                if(pr != null)
                {
                    pr.pr_cond = problem.pr_cond;
                    pr.pr_color = problem.pr_color;
                    pr.pr_text = problem.pr_text;
                    pr.pr_value = problem.pr_value;
                    pr.sens_id = problem.sens_id;
                    pr.pr_bound_value = problem.pr_bound_value;
                    pr.pr_nn = problem.pr_nn;
                    await _context.SaveChangesAsync();
                    return Json("200");
                }
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
                var rs = _context.dm_reason.Find(reason.rs_id);
                if(rs != null)
                {
                    rs.rs_text = reason.rs_text;
                    rs.rs_probability = reason.rs_probability;
                    rs.rs_value = reason.rs_value;
                    rs.sens_id = reason.sens_id;
                    rs.nn_rs = reason.nn_rs;
                    rs.rs_cond = reason.rs_cond;
                    await _context.SaveChangesAsync();
                    return Json("200");
                }
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
                var sol = _context.dm_solution.Find(solution.sol_id);
                if(sol != null)
                {
                    sol.sol_text = solution.sol_text;
                    sol.sol_par = solution.sol_par;
                    sol.sol_nn = solution.sol_nn;
                    sol.sens_id = solution.sens_id;
                    await _context.SaveChangesAsync();
                    return Json("200");  
                }
                _context.dm_solution.Add(solution);
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> DeleteProblem(int id)
        {
            try
            {
                _context.dm_problem.Remove(_context.dm_problem.FirstOrDefault((x)=> x.pr_id == id));
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> DeleteReason(int id)
        {
            try
            {
                _context.dm_reason.Remove(_context.dm_reason.FirstOrDefault((x)=> x.rs_id == id));
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> DeleteSolution(int id)
        {
            try
            {
                _context.dm_solution.Remove(_context.dm_solution.FirstOrDefault((x)=> x.sol_id == id));
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
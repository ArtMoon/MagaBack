using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;


namespace DIMON_APP.Controllers
{
    public class UserController : Controller
    {

        private PostgresDBContext context;
        public UserController(PostgresDBContext context)
        {
            this.context = context;

        }
    
        [HttpPost]
        public IActionResult Login(User user)
        {
            var usr = context.dm_users.FirstOrDefault(x => x.name == user.name && x.password == user.password);
            if (usr != null)
                return Json(usr);
            else return Json("404");
        }

    }
}

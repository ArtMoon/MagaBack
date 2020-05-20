using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

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
        public async Task<IActionResult> Register(User user)
        {
            try
            {
                user.password = GetSha256Hash(user.password);
                context.Add(user);
                await context.SaveChangesAsync();
                return Json(200);
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }

        }
    
        [HttpPost]
        public IActionResult Login(User user)
        {
            user.password = GetSha256Hash(user.password);
            var usr = context.dm_users.FirstOrDefault(x => x.email == user.email && x.password == user.password);
            if (usr != null)
                return Json(usr);
            else return Json(404);
        }

        [NonAction]
        private string GetSha256Hash(string text)
        {
            byte[] bytes = Encoding.Default.GetBytes(text);
            using(var sha = SHA256.Create())
            {
                var hash = sha.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-","");

            }
            
        }

    }
}

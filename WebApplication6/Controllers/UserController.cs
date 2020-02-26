using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System.IO;
using System;

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
        public string Index(User user)
        {
            if (context.dm_users.Any(x => x.name == user.name && x.password == user.password))
                return "Привет " + user.name;
            else return "404";
        }
    }
}

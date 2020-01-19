using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models;
using System.IO;
using System;

namespace DIMON_APP.Controllers
{
    public class UserController : Controller
    {
        private ExcelParser parser;

        private MyWebApiDbContext context;
        public UserController(MyWebApiDbContext context)
        {
            this.context = context;

        }
    
     
        [HttpPost]
        public string Index(User user)
        {
            if (context.Users.Any(x => x.Name == user.Name && x.Password == user.Password))
                return "Привет " + user.Name;
            else return "404";
        }
    }
}

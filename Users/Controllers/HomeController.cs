using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Users.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ViewResult Index() => View(new Dictionary<string, object> { ["Placeholder"] = "Placeholder" });
    }
}

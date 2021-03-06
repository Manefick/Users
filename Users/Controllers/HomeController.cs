﻿using System;
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
        public ViewResult Index() => View(GetData(nameof(Index)));
        [Authorize(Roles = "users")]
        public IActionResult OtherAction() => View("Index", GetData(nameof(OtherAction)));
        private Dictionary<string, object> GetData(string actionName) => new Dictionary<string, object>
        {
            ["action"] = actionName,
            ["User"] = HttpContext.User.Identity.Name,
            ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
            ["Auth Type"] = HttpContext.User.Identity.AuthenticationType,
            ["In Users Role"] = HttpContext.User.IsInRole("users")
        };
    }
}

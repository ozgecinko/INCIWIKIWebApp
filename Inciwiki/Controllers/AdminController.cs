using Inciwiki.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private IUserValidator<IdentityUser> userValidator;
        private IPasswordValidator<IdentityUser> passwordValidator;
        private IPasswordHasher<IdentityUser> passwordHasher;

        public AdminController(UserManager<IdentityUser> usrMgr,
                IUserValidator<IdentityUser> userValid,
                IPasswordValidator<IdentityUser> passValid,
                IPasswordHasher<IdentityUser> passwordHash)
        {
            userManager = usrMgr;
            userValidator = userValid;
            passwordValidator = passValid;
            passwordHasher = passwordHash;
        }

    }
}

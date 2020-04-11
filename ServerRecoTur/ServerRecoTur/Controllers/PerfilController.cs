using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ServerRecoTur.Models;

namespace ServerRecoTur.Controllers
{
    [Route("api/Perfil")]
    [ApiController]
    public class PerfilController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext context;

        public PerfilController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration _configuration,
            ApplicationDbContext context)
        {
            this.context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            this._configuration = _configuration;
        }
    }
}
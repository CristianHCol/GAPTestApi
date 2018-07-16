using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using GrowTestApi.Model;
using GrowTestApi.Services;

namespace GrowTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
            _authService.CreateUser();
        }


        [HttpPost(Name = "authenticate")]
        public IActionResult AuthStart([FromBody] User item)
        {
            var isValidLogin = _authService.Authentication(item.username, item.password);
            if (!isValidLogin)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
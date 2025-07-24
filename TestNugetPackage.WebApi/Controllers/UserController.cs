using Microsoft.AspNetCore.Mvc;
using PatronusR.Interfaces;
using TestNugetPackage.Application.Feature;
using TestNugetPackage.Application.Interface;

namespace TestNugetPackage.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPatronusR _patronusR;
        private readonly IUserService _userService;

        public UserController(IPatronusR patronusR, IUserService userService)
        {
            _patronusR = patronusR;
            _userService = userService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> TestPatronusR(CancellationToken cancellationToken = default)
        {
            var query = new GetAllUsersQuery();
            var users = await _patronusR.Send(query, cancellationToken); // Changed 'user' to 'users'
            return Ok(users);
        }
    }
}

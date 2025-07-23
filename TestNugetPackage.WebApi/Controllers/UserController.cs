using Microsoft.AspNetCore.Mvc;
using PatronusR.Contracts;
using System.Reflection;
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
        public async Task<IActionResult> TestMediator()
        {
            var result = await _patronusR.Send(new GetUserQuery());
            return Ok(result);
        }

        [HttpGet("debug-handler")]
        public IActionResult DebugHandler()
        {
            var handler = HttpContext.RequestServices
                .GetService<IRequestHandler<GetUserQuery, User>>();

            return Ok(new
            {
                HandlerRegistered = handler != null,
                HandlerType = handler?.GetType().FullName,
                UserServiceRegistered = handler != null &&
                    handler.GetType().GetField("_userService", BindingFlags.NonPublic | BindingFlags.Instance) != null
            });
        }
    }
}

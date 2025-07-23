using PatronusR.Contracts;
using TestNugetPackage.Application.Interface;

namespace TestNugetPackage.Application.Feature
{
    // Request
    public record GetUserQuery : IRequest<User>;

    // Handler
    public class GetUserHandler : IRequestHandler<GetUserQuery, User>
    {
        private readonly IUserService _userService;

        public GetUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _userService.GetAllUser();
        }
    }
}

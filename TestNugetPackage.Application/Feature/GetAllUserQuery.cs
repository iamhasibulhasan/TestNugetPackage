using PatronusR.Interfaces;
using TestNugetPackage.Application.Interface;

namespace TestNugetPackage.Application.Feature
{
    public class GetAllUsersQuery : IRequest<List<User>>;

    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserService _userService;

        public GetAllUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userService.GetAllUser();
        }
    }
}

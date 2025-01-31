using TaskHiveSyncs.Services;

namespace TaskHiveSyncs.AuthMutations
{
    public class AuthMutation
    {
        private readonly AuthenticationService _authService;

        public AuthMutation(AuthenticationService authService)
        {
            _authService = authService;
        }

    }
}

using RepositoryLayer;
using Models;

namespace BusinessLayer
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string RegisterUser(UserModel user)
        {
            bool isRegistered = _userRegistrationRL.Register(user);
            return isRegistered ? "Registration Successful" : "User Already Exists";
        }
    }
}

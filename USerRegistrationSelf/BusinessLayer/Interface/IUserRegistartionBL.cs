
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
   public interface IUserRegistartionBL
    {
        // string RegistrationBL(string username, string password);
        string registrationBL(string username);
        bool loginuser(LoginDTO loginDTO);
    }
}

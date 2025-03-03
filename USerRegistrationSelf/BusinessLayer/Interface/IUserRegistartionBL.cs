
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace BusinessLayer.Interface
{
   public interface IUserRegistartionBL
    {
        // string RegistrationBL(string username, string password);
        string registrationBL(string username);
        bool loginuser(LoginDTO loginDTO);
        UserEntity registerBL(RegisterDTO registerDTO);
    }
}

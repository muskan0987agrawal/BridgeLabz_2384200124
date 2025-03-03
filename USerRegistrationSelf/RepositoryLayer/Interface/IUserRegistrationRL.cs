

using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        string userRegistration(string mssge);
        //(string, string) registrationRL(string userName, string password);
        LoginDTO getUsernamePassword(LoginDTO loginDTO);

    }
}

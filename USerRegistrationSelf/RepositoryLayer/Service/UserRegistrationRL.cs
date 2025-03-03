using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service
{
    public class UserRegistrationRL:IUserRegistrationRL
    {
        private readonly ILogger<UserRegistrationRL> _logger;
        private string database_firstName = "Muskan";
        private string database_lastName = "Agrawal";
        private string database_Paassword = "1234";
        private string database_email= "muskan@gmail.com";
       

        private string databaseUsername = "root";
        private string databasePassword = "root";

        public UserRegistrationRL(ILogger<UserRegistrationRL> logger)
        {
            _logger = logger;
        }
        //public (string,string) registrationRL(string email, string password)
        //{
        //    return ("muskan@gmail.com","1234");
        //}

        public string userRegistration(string name)
        {
            try
            {
                return name + " Hello from Repository layer ";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetHello method");
                throw;
            }
        }

        public LoginDTO getUsernamePassword(LoginDTO loginDTO)
        {
            try
            {
                //loginDTO.FirstName = database_firstName;
                //loginDTO.LastName = database_lastName;
                //loginDTO.password = database_Paassword;
                //loginDTO.email = database_email;
                loginDTO.FirstName = "Muskan";
                loginDTO.LastName = "Agrawal";
                loginDTO.password = "1234";
                loginDTO.email = "muskan@1234";
                return loginDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching username and password");
                throw;
            }
        }
    }

}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly ILogger<UserRegistrationRL> _logger;
        private RegisterResponse obj;

        private readonly UserRegistrationContext _dbContext;

        private string database_firstName = "Muskan";
        private string database_lastName = "Agrawal";
        private string database_Paassword = "1234";
        private string database_email = "muskan@gmail.com";


        private string databaseUsername = "root";
        private string databasePassword = "root";

        public UserRegistrationRL(UserRegistrationContext context,ILogger<UserRegistrationRL> logger)
        {_dbContext = context;
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
                _logger.LogError("Error in userRegistration method", ex.Message);
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
                _logger.LogError("Error fetching username and password", ex.Message);
                throw;
            }
        }

        public UserEntity Registration(RegisterDTO registerDTO)
        {
            //obj = new RegistrationResponse();
           UserEntity existingUser = _dbContext.User.FirstOrDefault<UserEntity>(e => e.Email == registerDTO.Email);
            try
            {
                if (existingUser == null)
                {
                    var user = new UserEntity()
                    {
                        FirstName = registerDTO.FirstName,
                        LastName = registerDTO.LastName,
                        Email = registerDTO.Email,
                        Password = registerDTO.Password
                    };
                    _dbContext.Add(user);
                    _dbContext.SaveChanges();
                    _logger.LogInformation($"User registered successfully: {user.Email}");
                    return user;

                }
                else
                {
                    _logger.LogWarning($"User already exists with email: {registerDTO.Email}");

                    return existingUser;
                }

                return existingUser;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in RegisterUser: " + ex.Message);
                throw;
            }


        }
    }
    
}

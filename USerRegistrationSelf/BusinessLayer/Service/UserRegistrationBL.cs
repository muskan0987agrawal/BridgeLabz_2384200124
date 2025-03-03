
using RepositoryLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistartionBL
    {
       private readonly IUserRegistrationRL userRegistrationRL;
        private readonly ILogger<UserRegistrationBL> _logger;
        public UserRegistrationBL(IUserRegistrationRL userRegistrationRL, ILogger<UserRegistrationBL> logger)
        {
            this.userRegistrationRL = userRegistrationRL;
            _logger = logger;
        }

        public string registrationBL(string name)
        {
            try
            {
                return " Data from Business Layer " + userRegistrationRL.userRegistration(name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in registration for name: {Name}", name);
                throw;
            }
        }

        //public string RegistrationBL(string email, string password)
        //{
        //    var (Email, pass) = userRegistrationRL.registrationRL(email, password);
        //    if (Email == email&& pass == password)
        //    {
        //        return "Login Successful";
        //    }
        //    return "Invalid Email and password";
        //}

        public bool loginuser(LoginDTO loginDTO)
        {
            try
            {
                string frontendUserName = loginDTO.FirstName;
                string frontendPassword = loginDTO.password;
                string frontendEmail = loginDTO.email;
                LoginDTO result = userRegistrationRL.getUsernamePassword(loginDTO);
                bool res = checkUserNamePAssword(frontendUserName,frontendPassword, frontendEmail, result);
                if (res)
                    _logger.LogInformation("Login successful for user: {Username}", frontendEmail);
                else
                    _logger.LogWarning("Login failed for user: {Username}", frontendUserName);
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for user: {Username}", loginDTO.frontendUserName);
                throw;
            }
        }

        private bool checkUserNamePAssword( string frontendUserName,string frontendPassword, string forntendEmail, LoginDTO result)
        {
            try
            {
                if (frontendPassword.Equals(result.password) && forntendEmail.Equals(result.email))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CheckUsernamePassword for user: {Username}", frontendUserName);
                throw;
            }
        }


    }
}

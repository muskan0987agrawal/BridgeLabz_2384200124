using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using NLog;
namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistartionBL _registerHelloBL;
        private readonly ILogger<UserRegistrationController> _logger;
        ResponseModel<string> response;
        public UserRegistrationController(ILogger<UserRegistrationController> logger,IUserRegistartionBL _registerHelloBL)// dependency inject of businessLayer via constructor
        {
            this._registerHelloBL = _registerHelloBL;
            _logger = logger;
        }

        [HttpGet]
       
        public IActionResult Get()
        {
            try
            {
                _logger.LogInformation("Processing GET request in UserRegistration.");
                string result = _registerHelloBL.registrationBL("Value from controller");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred in GET request.");
                return StatusCode(500, "Internal Server Error");
            }
        }
        //[HttpGet]
        //public string Registration()
        //{

        //        string email= "muskan@gmail.com";
        //        string password = "1234";
        //        string msg = _registerHelloBL.RegistrationBL(email, password);
        //        return msg;
        //}


        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Login attempt for user:{ FirstName}", loginDTO.FirstName);
                response = new ResponseModel<string>();
                bool result = _registerHelloBL.loginuser(loginDTO);
                if (result)
                {
                    response.Success = true;
                    response.Message = "Login successful";
                    response.Data = loginDTO.ToString();
                    _logger.LogInformation("User {FirstName} logged in successfully", loginDTO.FirstName);
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Login failed";
                response.Data = null;
                _logger.LogWarning("Login failed for user: {FirstName}", loginDTO.FirstName);
                return NotFound();
            }

            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Login failed";
                response.Data = ex.Message;


                _logger.LogError(ex, "Exception during login for user: {FirstName}", loginDTO.FirstName);
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("register")]
        public IActionResult RegistrationUSer(RegisterDTO registerDTO)
        {

            try
            {

                var result = _registerHelloBL.registerBL(registerDTO);
                response = new ResponseModel<String>();
                response.Success = true;
                response.Message = "Registration Sucessful";
                //response.Data = result;
                return Created("user Register", result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in Register: " + ex.Message);
                return BadRequest(new { Error = ex.Message });
            }

        }
    }
}

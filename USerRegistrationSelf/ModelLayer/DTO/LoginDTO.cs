
namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string? frontendUserName;

        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string password { get; set; }

        public string email {  get; set; }

        override
        public string ToString()
        {
            return $"FirstName= {FirstName}: LastNam= {LastName} : Email = {email} ";
        }
    }

       
}

﻿

using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        string userRegistration(string mssge);
        //(string, string) registrationRL(string userName, string password);
        LoginDTO getUsernamePassword(LoginDTO loginDTO);
        UserEntity Registration(RegisterDTO registerDTO);
    }

}

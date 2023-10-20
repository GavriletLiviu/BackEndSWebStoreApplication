using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;


namespace ServiceContracts.DTO
{
    public class UserAddRequest
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public RegisterUser ToUser()
        {
            return new RegisterUser()
            {
                UserName = UserName,
                Email = Email,
                Password = Password,
                ConfirmPassword = ConfirmPassword
            };
        }
    }
}

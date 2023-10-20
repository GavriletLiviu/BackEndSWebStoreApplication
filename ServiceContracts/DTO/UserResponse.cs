using System;
using System.Collections.Generic;
using ServiceContracts.DTO;
using StoreBackEnd.Entities;

namespace ServiceContracts.DTO
{
    public class UserResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}

public static class UserExtensions
{
    public static UserResponse ToUserResponse(this RegisterUser user)
    {
        return new UserResponse()
        {
            UserName = user.UserName,
            Email = user.Email,
            Password = user.Password,
            ConfirmPassword = user.ConfirmPassword,
        };
    }
}

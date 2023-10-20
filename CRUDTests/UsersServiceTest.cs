using ServiceContracts.DTO;
using ServiceContracts;
using StoreBackEnd;
using Services;

using System;
using System.Collections.Generic;

namespace CRUDTests
{
    public class UsersServiceTest
    {
        private readonly IUsersService _usersService;

        public UsersServiceTest()
        {
            _usersService = new RegisterUserService();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Entities;

namespace StoreBackEnd.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersService _usersService;
        private readonly RegisterUsersService _registerUsersService;

        public UsersController()
        {
            _usersService = new UsersService();
            _registerUsersService = new RegisterUsersService();
        }
        
        [Route("/register/{UserName}/{Email}/{Password}/{ConfirmPassword}")]
        [HttpPost]
        public IActionResult Register(string UserName, string Email, string Password, string ConfirmPassword)
        {
            //var tempuser = new Services.Entities.RegisterUser { UserName = regUser.UserName , Email = regUser.Email, ConfirmPassword=regUser.ConfirmPassword, Password=regUser.Password};
            //_registerUsersService.AddUser()
            bool success = _registerUsersService.AddUser(UserName, Email, Password, ConfirmPassword);
            if(success)
            {
                return Json(true);
            }
            return Json(false);
        }
        
        [Route("/login/{UserName}/{Password}")]
        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            if(_registerUsersService.VerifyUser(UserName, Password))
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}

using Services.Entities;
using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Services
{
    public class RegisterUsersService
    {
        public List<RegisterUser> _users;
        private string _filePath = "users.txt";
        public RegisterUsersService() 
        {
            _users = new List<RegisterUser>();
            RegisterUser user = new RegisterUser("test", "test", "test", "test");
            _users.Add(user);

            if (File.Exists(_filePath))
            {
                ReadUsersFromFile();
            }
            else
            {
                File.Create(_filePath).Close();
            }

        }
        public List<RegisterUser> GetUsers()
        {
            return _users;
        }

        public bool AddUser(string UserName, string Email, string Password, string ConfirmPassword)
        {
            RegisterUser user = new Services.Entities.RegisterUser(UserName, Email, Password, ConfirmPassword);
            if(user.Password == user.ConfirmPassword)
            {
                _users.Add(user);
                WriteUsersToFile();
                return true;
            }
            return false;
        }

        public bool VerifyUser(string UserName, string Password)
        {
            ReadUsersFromFile();
            foreach (RegisterUser user in _users)
            {
                if (user.UserName == UserName && user.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }

        private void ReadUsersFromFile()
        {
            string[] lines = File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                string[] userData = line.Split(",");
                if(userData.Length == 4)
                {
                    RegisterUser user = new RegisterUser(userData[0], userData[1], userData[2], userData[3]);
                    _users.Add(user);
                }
            }
        }

        private void WriteUsersToFile()
        {
            List<string> lines = new List<string>();
            foreach (RegisterUser user in _users)
            {
                string userData = $"{user.UserName},{user.Email},{user.Password},{user.ConfirmPassword}";
                lines.Add(userData);
            }
            File.WriteAllLines(_filePath, lines);
        }
    }
}

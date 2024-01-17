using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAdmin
{
    interface ISecurity
    {
        
    }

    interface IGeneratePassword
    {
        string Hash(string password);
        string GenerateSalt();
    }

    public class Security : ISecurity
    {
        private string _password;
        private string _salt;
        private IGeneratePassword _generatePassword;

        public Security(string password)
        {
            _generatePassword = new GeneratePassword();
            SetPassword(password);
        }
        public Security(string password,string salt)
        {
            _generatePassword = new GeneratePassword();
            SetPassword(password,salt);
        }

        public string Password
        {
            get { return _password; }
            set { SetPassword(value); }
        }
        public string PasswordCheck
        {
            get { return _password; }
            set { SetPassword(value,value); }
        }

        public string Salt
        {
            get { return _salt; }
            private set { _salt = value; }
        }

        private void SetPassword(string password)
        {
            _password = password;
            Salt = _generatePassword.GenerateSalt();
            _password = _generatePassword.Hash(_password + Salt);
        }
        private void SetPassword(string password, string salt)
        {
            _password = password;
            Salt = salt;
            _password = _generatePassword.Hash(_password + salt);
        }

        class GeneratePassword : IGeneratePassword
        {
            public string Hash(string password)
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    return Convert.ToBase64String(hashBytes);
                }
            }

            public string GenerateSalt()
            {
                int length = 50;
                const string availableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

                StringBuilder sb = new StringBuilder();
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(availableChars.Length);
                    sb.Append(availableChars[index]);
                }

                return sb.ToString();
            }
        }
    }
}

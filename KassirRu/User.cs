using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassirRu
{
    class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public decimal Money { get; set; }
        public User()
        { }
        public User(string Email, string Password, string Role)
        {
            this.Password = Password;
            this.Role = Role;
            this.Email = Email;
            Money = 0;
        }
    }
}

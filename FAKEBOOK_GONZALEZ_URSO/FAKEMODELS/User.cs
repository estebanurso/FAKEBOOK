using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAKEMODELOS
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } //Nombre y Apellido
        public string Mail { get; set; }

        public User()
        {
            Id = 0;
            UserName = "";
            Mail = "";
        }

        public User(string firstName, string lastName, string mail)
        {
            Id = 1;
            UserName = string.Concat(firstName, " ", lastName);
            Mail = mail;
        }
    }
}

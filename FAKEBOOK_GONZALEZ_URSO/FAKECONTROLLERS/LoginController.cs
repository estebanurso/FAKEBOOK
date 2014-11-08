using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FAKEMODELOS;
using System.Security.Cryptography;
using FAKECONTROLLERS.Helpers;

namespace FAKECONTROLLERS
{
    public class LoginController
    {
        public bool ValidateLogin(string userMail, string pass)
        {
            bool isValid = false;

            User user = getUser(userMail);

            if (user != null)
            {
                isValid = validatePassword(user, pass);
            }

            return isValid;
        }

        private User getUser(string userMail)
        {
            User user = null;

            //Esto es un MOCK por el momento para que devuelva algo, pero deberia llamar a una funcion del mapper
            if (string.Compare(userMail, "a@a.com") == 0)
            {
                user = new User("test", "test", "a@a.com");
            }

            return user;
        }

        private bool validatePassword(User user, string pass)
        {
            bool isValid = false;
            string sourcePass = getPasswordByUser(user.Id);

            string passEncoded = encodePassword(pass);

            isValid = (string.Compare(sourcePass, passEncoded) == 0);

            return isValid;
        }

        private string getPasswordByUser(int userId)
        {
            string passFromDataBase = string.Empty;

            //DAO.GetPassFromUserId(userId);
            
            if (userId == 1)
            {
                //En la base el password se guarda como un string ya codificado, por ende este paso no seria necesario
                passFromDataBase = encodePassword("Lalala");
            }

            return passFromDataBase;
        }

        private string encodePassword(string pass)
        {
            EncodeHelper encoder = new EncodeHelper();
            return encoder.Encode(pass);
        }
    }
}

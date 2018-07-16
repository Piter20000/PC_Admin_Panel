using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Admin_Panel.Classes
{
    class Admin : Basic_Class
    {
        //   ###   Propeties   ###   //

        private string _login;
        private string _password;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //   ###   Constructors   ###   //

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        public Admin(string Login, string Password) : base()
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}

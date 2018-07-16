namespace PC_Admin_Panel.Classes
{
    class Session : Basic_Class
    {
        //   ###   Propeties   ###   //

        private static string _admin_Login;
        private static string _admin_password;

        public static string Admin_Login
        {
            get { return _admin_Login; }
            set { _admin_Login = value; }
        }
        public static string Admin_Password
        {
            get { return _admin_password; }
            set { _admin_password = value; }
        }

        //   ###   Methods   ###   //

        /// <summary>
        /// Method clear session data
        /// </summary>
        public static void  Session_Clear()
        {
            Admin_Login = null;
            Admin_Password = null;
        }
    }
}

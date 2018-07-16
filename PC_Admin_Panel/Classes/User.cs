namespace PC_Admin_Panel.Classes
{
    class User : Basic_Class
    {

        //   ###   Class propeties   ###   //

        #region Propeties

        private int _uid;
        private string _fuid;
        private string _guid;
        private string _fname;
        private string _lname;
        private string _email;
        private string _fullname;
        private string _fblink;
        private string _gender;
        private string _dp;
        private string _lastlogin;
        private string _registrationtime;
        private string _referal;
        private string _lastmodified;

        public int Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        public string Fuid
        {
            get { return _fuid; }
            set { _fuid = value; }
        }
        public string Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        public string Fblink
        {
            get { return _fblink; }
            set { _fblink = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Dp
        {
            get { return _dp; }
            set { _dp = value; }
        }
        public string LastLogIn
        {
            get { return _lastlogin; }
            set { _lastlogin = value; }
        }
        public string RegistrationTime
        {
            get { return _registrationtime; }
            set { _registrationtime = value; }
        }
        public string Referal
        {
            get { return _referal; }
            set { _referal = value; }
        }
        public string LastModified
        {
            get { return _lastmodified; }
            set { _lastmodified = value; }
        }

        #endregion

        //   ###   Class constructor   ###   //

        /// <summary>
        /// Basic class constructor
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fuid"></param>
        /// <param name="guid"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="email"></param>
        /// <param name="fullname"></param>
        /// <param name="fblink"></param>
        /// <param name="gender"></param>
        /// <param name="dp"></param>
        /// <param name="lastlogin"></param>
        /// <param name="registrationtime"></param>
        /// <param name="referal"></param>
        /// <param name="lastmodified"></param>
        /// <param name="Error_Message"></param>
        /// <param name="Error_Flag"></param>
        public User(
            int uid,
            string fuid,
            string guid,
            string fname,
            string lname,
            string email,
            string fullname,
            string fblink,
            string gender,
            string dp,
            string lastlogin,
            string registrationtime,
            string referal,
            string lastmodified,
            string Error_Message,
            bool Error_Flag
            ) :base(Error_Message, Error_Flag)
        {
            _uid = uid;
            _fuid = fuid;
            _guid = guid;
            _fname = fname;
            _lname = lname;
            _email = email;
            _fullname = fullname;
            _fblink = fblink;
            _gender = gender;
            _dp = dp;
            _lastlogin = lastlogin;
            _registrationtime = registrationtime;
            _referal = referal;
            _lastmodified = lastmodified;
        }

        //   ###   Methods   ###   //

        public override string ToString()
        {
            return $"\n Uid: {Uid}" +
                $" Fuid: {Fuid}" +
                $" Gid: {Guid}" +
                $" First name: {Fname}" +
                $" Last name: {Lname}" +
                $" E-mail: {Email}" +
                $" Full name: {FullName}" +
                $" Fblink: {Fblink}" +
                $" Gender: {Gender}" +
                $" Dp: {Dp}" +
                $" Last log in: {LastLogIn}" +
                $" Registration time: {RegistrationTime}" +
                $" Referal: {Referal}" +
                $" Last modified: {LastModified}";
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace PC_Admin_Panel.Core
{
    class Process : Classes.Basic_Class
    {
        //   ###   Colections   ###   //

        public static List<Classes.Admin> Admins_List = new List<Classes.Admin>();

        public static List<Classes.User> Users_list = new List<Classes.User>();

        public static List<Classes.Pack> Packs_List = new List<Classes.Pack>();

        //   ###   Methods   ###   //

        /// <summary>
        /// Method load list of admins from the server
        /// </summary>
        public void Load_Admins_List()
        {
            // Create instance of Database Connection
            Classes.Database conn = new Classes.Database();

            // Load list of users from server
            conn.Select_Admins(ref Admins_List);

            // Check error flag
            if (conn.Error_Flag)
            {
                // Set main error flag as true
                Error_Flag = true;
                // Set main error message
                Error_Message = conn.Error_Message;
            }
        }

        /// <summary>
        /// Method load list of users from the server
        /// </summary>
         public void Load_Users_List()
        {
            // Create instance of Database Connection
            Classes.Database conn = new Classes.Database();

            // Load list of users from server
            conn.Select_Users(ref Users_list);

            // Check error flag
            if(conn.Error_Flag)
            {
                // Set main error flag as true
                Error_Flag = true;
                // Set main error message
                Error_Message = conn.Error_Message;
            }
        }

        /// <summary>
        /// Method load list of packs from the server
        /// </summary>
        public void Load_Packs_List()
        {
            // Create instance of Database Connection
            Classes.Database conn = new Classes.Database();

            // Load list of packs from server
            conn.Select_Packs(ref Packs_List);

            // Check error flag
            if (conn.Error_Flag)
            {
                // Set main error flag as true
                Error_Flag = true;
                // Set main error message
                Error_Message = conn.Error_Message;
            }
        }

        /// <summary>
        /// Method send informations about IP adress into database on the server
        /// </summary>
        public async void Send_IP_Raport_Into_Server()
        {
            // Preare async method
            Task<string> task = new Task<string>(Classes.IP_Data.Get_Data_From_IP);

            // Start working async
            task.Start();

            // Create instance of Database Connection
            Classes.Database conn = new Classes.Database();

            // Wait for results
            var query = await task;

            // Send IP data into server
            conn.Insert(query);

            // Check error flag
            if (conn.Error_Flag)
            {
                // Set main error flag as true
                Error_Flag = true;
                // Set main error message
                Error_Message = conn.Error_Message;
            }
        }

        /// <summary>
        /// Method create & send informations about PC adress into database on the server
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public void Send_PC_Raport_Into_Server()
        {

            // Create class with informations about user's PC
            Classes.PC_Data A = new Classes.PC_Data();

            var query = A.Query;

            // Create instance of Database Connection
            Classes.Database conn = new Classes.Database();

            // Load list of packs from server
            conn.Insert(query);

            // Check error flag
            if (conn.Error_Flag)
            {
                // Set main error flag as true
                Error_Flag = true;
                // Set main error message
                Error_Message = conn.Error_Message;
            }
        }

        /// <summary>
        /// Method check account exists in Admins_List
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns> 
        /// If exists return true
        /// Else return flase
        /// </returns>
        public bool Check_Admin(string Login, string Password)
        {
            if (Admins_List.Exists(x => x.Login == Login && x.Password == Password))
            {
                Classes.Session.Admin_Login = Login;
                Classes.Session.Admin_Password = Password;

                // Create instance of Database Connection
                Classes.Database conn = new Classes.Database();

                // Wait for results
                var query = $"UPDATE admins SET last_logedin = NOW() WHERE login='{Login}'";

                // Send IP data into server
                conn.Update(query);

                // Check error flag
                if (conn.Error_Flag)
                {
                    // Set main error flag as true
                    Error_Flag = true;
                    // Set main error message
                    Error_Message = conn.Error_Message;
                }

                return true;
            }
            else
                return false;
        }
    }
}

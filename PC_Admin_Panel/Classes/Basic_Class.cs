using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Admin_Panel.Classes
{
     abstract class Basic_Class
    {
        //   ###   Error message & flag   ###   //

        private string _error_message;
        private bool _error_flag;

        public string Error_Message
        {
            get { return _error_message; }
            set { _error_message = value; }
        }
        public bool Error_Flag
        {
            get { return _error_flag; }
            set { _error_flag = value; }
        }

        //   ###   Comstructors   ###   // 

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Error_Message"></param>
        /// <param name="Error_Flag"></param>
        public Basic_Class( string Error_Message = null, bool Error_Flag = false)
        {
            this.Error_Message = Error_Message;
            this.Error_Flag = Error_Flag;
        }

        //   ###   Methods   ###   //

        /// <summary>
        /// Method check if any error exists
        /// If true, reset flag & message, then return error message
        /// Else return null string
        /// </summary>
        /// <returns> Result in string form </returns>
        public string Check_Errors()
        {
            if (Error_Flag)
            {
                // Reset error flag
                Error_Flag = false;

                // Copy error message
                string message = Error_Message;

                // Reset error message
                Error_Message = null;

                return message;
            }
            else
                return null;
        }
    }
}

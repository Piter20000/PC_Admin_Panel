using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Admin_Panel.Forms
{
    public partial class Create_Admin : Form
    {
        public Create_Admin()
        {
            InitializeComponent();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Classes.Database Database = new Classes.Database();

            bool flag = true;

                // Check if login already exists in database
                if (Check_If_Exists(Database) > 0)
                {
                    MessageBox.Show("Nick reserved", "Nick error");

                    Login_Textbox.BackColor = System.Drawing.Color.Red;

                    flag = false;
                }
                if (Login_Textbox.Text.Length < 6)
                {
                    MessageBox.Show("Login must have at list 7 chars", "Password error");

                    Login_Textbox.BackColor = System.Drawing.Color.Red;

                flag = false;
            }
                // Check password length
                if (Password1_Textbox.Text.Length < 6)
                {
                    MessageBox.Show("Password must have at list 7 chars", "Password error");

                    Password1_Textbox.BackColor = System.Drawing.Color.Red;
                    Password2_Textbox.BackColor = System.Drawing.Color.Red;

                    flag = false;
                }
                // Comparing passwords 
                if (Password1_Textbox.Text != Password2_Textbox.Text)
                {
                    MessageBox.Show("Different passwords", "Password error");
                    Password1_Textbox.BackColor = System.Drawing.Color.Red;
                    Password2_Textbox.BackColor = System.Drawing.Color.Red;

                    flag = false;
                }

            if (flag)
            {
                // Create admin account
                Add_New_Admin(Database);

                // Close Create_Admin form
                this.Close();
            }
        }

        /// <summary>
        /// Method add new admin into database
        /// </summary>
        /// <param name="Database"></param>
        private void Add_New_Admin(Classes.Database Database)
        {
            // Prepare query
            var query = $"INSERT INTO admins (login, password, last_logedin) VALUES ('{Login_Textbox.Text.ToString()}', '{Password1_Textbox.Text.ToString()}', NOW())";

            // Add new rew into database
            Database.Insert(query);
        }

        /// <summary>
        /// Method check if in our database already exists "login"
        /// </summary>
        /// <param name="Database"></param>
        /// <returns> Number of found objects </returns>
        private int Check_If_Exists(Classes.Database Database)
        {
            // Prepare query
            var query = $"SELECT COUNT(*) FROM admins WHERE login = '{Login_Textbox.Text.ToString()}'";

            // Send ask 
            // Return result
            return Database.Count(query);
        }
    }
}

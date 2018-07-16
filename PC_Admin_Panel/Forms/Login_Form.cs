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
    public partial class Login_Form : Form
    {
        Core.Process Process = new Core.Process();

        public Login_Form()
        {
            InitializeComponent();

            // Hide entered text
            Password_TxtBox.UseSystemPasswordChar = true;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            // Load list of admins from server
            Process.Load_Admins_List();

            // Check if admin exists
            if (Process.Check_Admin(Login_TxtBox.Text, Password_TxtBox.Text))
            {
                // Hide Login_Form
                this.Hide();

                // Create instance of Main_Form
                var Main_Form = new Main_Form();

                // Display Main_Form
                Main_Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
                Login_TxtBox.Text = null;
                Password_TxtBox.Text = null;
            }

            // Check error flag during connection
            if (Process.Error_Flag)
                MessageBox.Show(Process.Check_Errors());
        }
    }
}

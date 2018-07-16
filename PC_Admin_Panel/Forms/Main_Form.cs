using System;
using System.Windows.Forms;

namespace PC_Admin_Panel.Forms
{
    public partial class Main_Form : Form
    {
        // Create instance of Process
        Core.Process Core = new Core.Process();

        // Create instance of Database
        Classes.Database Database = new Classes.Database();

        // Flag - pointing into current list
        private int pointer = 0;

        /// <summary>
        /// Class constructor
        /// </summary>
        public Main_Form()
        {
            InitializeComponent();

            // Load Users_List
            Core.Load_Users_List();
            // Load Packs_List
            Core.Load_Packs_List();

            // Send raport about IP
            Core.Send_IP_Raport_Into_Server();
            // Send raport about PC
            Core.Send_PC_Raport_Into_Server();

            // Display informations about logged admin
            Logged_As_Label.Text = $"Logged as \"{Classes.Session.Admin_Login}\"";

            // User can't modified rows in Display_DataGridView
            Display_DataGridView.AllowUserToAddRows = false;

            // Set default colors
            Set_Button_Color(pointer);
        }

        #region Buttons click events

        private void Packs_List_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_Packs_List();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 1;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Unpaid_Pack_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_Unpaied_Packs_List();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 2;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Undelivered_Packs_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_Undelivered_Packs_List();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 3;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Users_List_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_Users_List();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 4;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Admins_List_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_Admins_List();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 5;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Load_PC_Data_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_PC_Data_Informations();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 6;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Load_IP_Data_Button_Click(object sender, System.EventArgs e)
        {
            // Display data from server
            Display_DataGridView.DataSource = Database.Load_IP_Data_Informations();

            // Reset buttons colors
            Set_Button_Color(0);

            pointer = 7;

            // Change color on the button 
            Set_Button_Color(pointer);

            // Set buttons as availabe
            Change_Button_Access(pointer);
        }

        private void Display_DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if any row is selected
            if (Display_DataGridView.SelectedRows.Count>0)
            {
                //Change_Button_Access(pointer);
            }
        }

        // Functions buttons

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            // Create instance of Create_Admin
            var Create_Admin = new Create_Admin();

            // Display Create_Admin
            Create_Admin.ShowDialog();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            // Remove admin
            Remove_Admin();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            // Button prepared just in case
        }

        private void Paid_Button_Click(object sender, EventArgs e)
        {
            // Update 
            Update_As_Paid();
        }

        private void Delivered_Button_Click(object sender, EventArgs e)
        {
            // Update 
            Update_As_Delivered();
        }

        #endregion

        //   ###   Methods   ###   ///

        /// <summary>
        /// Method return information about selected row in DataGridView
        /// </summary>
        /// <param name="pointer"></param>
        /// <returns> Informations in string form </returns>
        private string Show_Detals(int pointer)
        {
            string answer = null;
            string info = null;

            switch (pointer)
            {
                case 1:
                case 2:
                case 3:
                    answer = $"Current row informations:\n" +
                        $"" +
                        $" User ID: {Display_DataGridView.CurrentRow.Cells[1].Value.ToString()}\n" +
                        $" First name: {Display_DataGridView.CurrentRow.Cells[2].Value.ToString()}\n" +
                        $" Last name: {Display_DataGridView.CurrentRow.Cells[3].Value.ToString()}\n" +
                        $" Phone: {Display_DataGridView.CurrentRow.Cells[4].Value.ToString()}\n" +
                        $" Country: {Display_DataGridView.CurrentRow.Cells[5].Value.ToString()}\n" +
                        $" Postal code: {Display_DataGridView.CurrentRow.Cells[6].Value.ToString()}\n" +
                        $" Place: {Display_DataGridView.CurrentRow.Cells[7].Value.ToString()}\n" +
                        $" House number: {Display_DataGridView.CurrentRow.Cells[8].Value.ToString()}\n" +
                        $" Weigth: {Display_DataGridView.CurrentRow.Cells[9].Value.ToString()}\n" +
                        $" Price: {Display_DataGridView.CurrentRow.Cells[10].Value.ToString()}\n" +
                        $" Quantity: {Display_DataGridView.CurrentRow.Cells[11].Value.ToString()}\n" +
                        $" Insurance: {Display_DataGridView.CurrentRow.Cells[12].Value.ToString()}\n" +
                        $" Status: {Display_DataGridView.CurrentRow.Cells[13].Value.ToString()}\n" +
                        $" Position: {Display_DataGridView.CurrentRow.Cells[14].Value.ToString()}\n" +
                        $" Option: {Display_DataGridView.CurrentRow.Cells[15].Value.ToString()}\n" +
                        $" Ordered data: {Display_DataGridView.CurrentRow.Cells[16].Value.ToString()}\n" +
                        $" Delivered data: {Display_DataGridView.CurrentRow.Cells[17].Value.ToString()}\n" +
                        $" Status checked by: {Display_DataGridView.CurrentRow.Cells[18].Value.ToString()}\n" +
                        $" Delivered checked by: {Display_DataGridView.CurrentRow.Cells[19].Value.ToString()}\n";
                    break;
                case 4:
                    answer = $"Current row informations:\n" +
                        $"" +
                        $" User ID: {Display_DataGridView.CurrentRow.Cells[0].Value.ToString()}\n" +
                        $" Facebook ID: {Display_DataGridView.CurrentRow.Cells[1].Value.ToString()}\n" +
                        $" Gmail ID: {Display_DataGridView.CurrentRow.Cells[2].Value.ToString()}\n" +
                        $" First name: {Display_DataGridView.CurrentRow.Cells[3].Value.ToString()}\n" +
                        $" Last name: {Display_DataGridView.CurrentRow.Cells[4].Value.ToString()}\n" +
                        $" E-mail: {Display_DataGridView.CurrentRow.Cells[5].Value.ToString()}\n" +
                        $" Password: {Display_DataGridView.CurrentRow.Cells[6].Value.ToString()}\n" +
                        $" Full name: {Display_DataGridView.CurrentRow.Cells[7].Value.ToString()}\n" +
                        $" Fblink: {Display_DataGridView.CurrentRow.Cells[8].Value.ToString()}\n" +
                        $" Gender: {Display_DataGridView.CurrentRow.Cells[9].Value.ToString()}\n" +
                        $" DP: {Display_DataGridView.CurrentRow.Cells[10].Value.ToString()}\n" +
                        $" Recently logged: {Display_DataGridView.CurrentRow.Cells[11].Value.ToString()}\n" +
                        $" Registered: {Display_DataGridView.CurrentRow.Cells[12].Value.ToString()}\n" +
                        $" Referal: {Display_DataGridView.CurrentRow.Cells[13].Value.ToString()}\n" +
                        $" Last modified: {Display_DataGridView.CurrentRow.Cells[14].Value.ToString()}\n" +
                        $" Phone: {Display_DataGridView.CurrentRow.Cells[15].Value.ToString()}\n";
                    break;
                case 5:
                    answer = $"Current row informations:\n" +
                        $"" +
                        $" Admin / Login: {Display_DataGridView.CurrentRow.Cells[0].Value.ToString()}\n" +
                        $" last_loggedin: {Display_DataGridView.CurrentRow.Cells[2].Value.ToString()}\n";
                    break;
                case 6:
                    answer = $"Current row informations:\n" +
                        $"" +
                        $" Admin ID: {Display_DataGridView.CurrentRow.Cells[1].Value.ToString()}\n" +
                        $" Internet provider's IP: {Display_DataGridView.CurrentRow.Cells[2].Value.ToString()}\n" +
                        $" User ID: {Display_DataGridView.CurrentRow.Cells[3].Value.ToString()}\n" +
                        $" Windows version: {Display_DataGridView.CurrentRow.Cells[4].Value.ToString()}\n" +
                        $" 64BitOS: {Display_DataGridView.CurrentRow.Cells[5].Value.ToString()}\n" +
                        $" PC name: {Display_DataGridView.CurrentRow.Cells[6].Value.ToString()}\n" +
                        $" CPUS number: {Display_DataGridView.CurrentRow.Cells[7].Value.ToString()}\n" +
                        $" Logical drivers available: {Display_DataGridView.CurrentRow.Cells[8].Value.ToString()}\n" +
                        $" Windows folder path: {Display_DataGridView.CurrentRow.Cells[9].Value.ToString()}\n" +
                        $" Host name: {Display_DataGridView.CurrentRow.Cells[10].Value.ToString()}\n" +
                        $" Domain name: {Display_DataGridView.CurrentRow.Cells[11].Value.ToString()}\n" +
                        $" Recently logged: {Display_DataGridView.CurrentRow.Cells[12].Value.ToString()}\n";
                    break;
                case 7:
                    answer = $"Current row informations:\n" +
                        $"" +
                        $" Admin ID: {Display_DataGridView.CurrentRow.Cells[1].Value.ToString()}\n" +
                        $" Computer IP: {Display_DataGridView.CurrentRow.Cells[2].Value.ToString()}\n" +
                        $" User ID: {Display_DataGridView.CurrentRow.Cells[3].Value.ToString()}\n" +
                        $" Recently logged: {Display_DataGridView.CurrentRow.Cells[4].Value.ToString()}\n" +
                        $" City: {Display_DataGridView.CurrentRow.Cells[5].Value.ToString()}\n" +
                        $" Region: {Display_DataGridView.CurrentRow.Cells[6].Value.ToString()}\n" +
                        $" Region code: {Display_DataGridView.CurrentRow.Cells[7].Value.ToString()}\n" +
                        $" Country: {Display_DataGridView.CurrentRow.Cells[8].Value.ToString()}\n" +
                        $" Country name: {Display_DataGridView.CurrentRow.Cells[9].Value.ToString()}\n" +
                        $" Continent code: {Display_DataGridView.CurrentRow.Cells[10].Value.ToString()}\n" +
                        $" In EU: {Display_DataGridView.CurrentRow.Cells[11].Value.ToString()}\n" +
                        $" Postal: {Display_DataGridView.CurrentRow.Cells[12].Value.ToString()}\n" +
                        $" Latitude: {Display_DataGridView.CurrentRow.Cells[13].Value.ToString()}\n" +
                        $" Longitude: {Display_DataGridView.CurrentRow.Cells[14].Value.ToString()}\n" +
                        $" Time zone: {Display_DataGridView.CurrentRow.Cells[15].Value.ToString()}\n" +
                        $" UTC offset: {Display_DataGridView.CurrentRow.Cells[16].Value.ToString()}\n" +
                        $" Country calling code: {Display_DataGridView.CurrentRow.Cells[17].Value.ToString()}\n" +
                        $" Currency: {Display_DataGridView.CurrentRow.Cells[18].Value.ToString()}\n" +
                        $" Language: {Display_DataGridView.CurrentRow.Cells[19].Value.ToString()}\n" +
                        $" ASN: {Display_DataGridView.CurrentRow.Cells[20].Value.ToString()}\n" +
                        $" ORG: {Display_DataGridView.CurrentRow.Cells[21].Value.ToString()}\n";
                    break;
                default:
                    answer = "You must select any row";
                    break;
            }
            return answer;
        }

        /// <summary>
        /// Method change cholors in accessible buttons
        /// And paint in red selected list_button
        /// </summary>
        /// <param name="pointer"></param>
        public void Set_Button_Color(int pointer)
        {
            switch (pointer)
            {
                case 1:
                    // Packs
                    Packs_List_Button.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    // Unpaid
                    Unpaid_Pack_Button.BackColor = System.Drawing.Color.Red;

                    Paid_Button.BackColor = System.Drawing.Color.GreenYellow;
                    Delivered_Button.BackColor = System.Drawing.Color.GreenYellow;
                    break;
                case 3:
                    // Undelivered
                    Undelivered_Packs_Button.BackColor = System.Drawing.Color.Red;

                    Delivered_Button.BackColor = System.Drawing.Color.GreenYellow;
                    break;
                case 4:
                    // Users
                    Users_List_Button.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    // Admins
                    Admins_List_Button.BackColor = System.Drawing.Color.Red;

                    Insert_Button.BackColor = System.Drawing.Color.GreenYellow;
                    Delete_Button.BackColor = System.Drawing.Color.GreenYellow;
                    break;
                case 6:
                    // PC
                    Load_PC_Data_Button.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    // IP
                    Load_IP_Data_Button.BackColor = System.Drawing.Color.Red;
                    break;
                default:
                    // Lists buttons
                    Packs_List_Button.BackColor = System.Drawing.Color.Gray;
                    Unpaid_Pack_Button.BackColor = System.Drawing.Color.Gray;
                    Undelivered_Packs_Button.BackColor = System.Drawing.Color.Gray;
                    Users_List_Button.BackColor = System.Drawing.Color.Gray;
                    Admins_List_Button.BackColor = System.Drawing.Color.Gray;
                    Load_PC_Data_Button.BackColor = System.Drawing.Color.Gray;
                    Load_IP_Data_Button.BackColor = System.Drawing.Color.Gray;
                    // Options buttons
                    Insert_Button.BackColor = System.Drawing.Color.Gray;
                    Update_Button.BackColor = System.Drawing.Color.Gray;
                    Delete_Button.BackColor = System.Drawing.Color.Gray;
                    Paid_Button.BackColor = System.Drawing.Color.Gray;
                    Delivered_Button.BackColor = System.Drawing.Color.Gray;
                    break;
            }
        }

        /// <summary>
        ///  Method modifie button access
        /// </summary>
        /// <param name="pointer"> Flag pointing into current list </param>
        public void Change_Button_Access(int pointer)
        {
            switch (pointer)
            {
                case 1:
                    // Packs
                    Insert_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = false;
                    break;
                case 2:
                    // Unpaid
                    Insert_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Paid_Button.Enabled = true;
                    Delivered_Button.Enabled = true;
                    break;
                case 3:
                    // Undelivered
                    Insert_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = true;
                    break;
                case 4:
                    // Users
                    Insert_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = false;
                    break;
                case 5:
                    // Admins
                    Insert_Button.Enabled = true;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = true;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = false;
                    break;
                case 6:
                    // PC
                    Insert_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = false;
                    break;
                case 7:
                    // IP
                    Insert_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = false;
                    break;
                default:
                    Insert_Button.Enabled = false;
                    Delete_Button.Enabled = false;
                    Update_Button.Enabled = false;
                    Paid_Button.Enabled = false;
                    Delivered_Button.Enabled = false;
                    break;
            }
        }


        public void Update_As_Paid()
        {
            // Copy pack id
            string pack_id = Display_DataGridView.CurrentRow.Cells[0].Value.ToString();
            // Copy UID
            string UID = Display_DataGridView.CurrentRow.Cells[1].Value.ToString();
            // Copy pack name
            string name = Display_DataGridView.CurrentRow.Cells[20].Value.ToString();

            string User_Email = null;

            // Find User e-mail
            foreach (var user in PC_Admin_Panel.Core.Process.Users_list)
            {
                if (UID.ToString() == user.Uid.ToString())
                    User_Email = user.Email;
            }

            if(User_Email == null)
                MessageBox.Show("We can't find User in our Database!");
            else
            {
                string message = $"We've just received your payment for <b>{name}</b>, pack id: <b>{pack_id}</b> <br /> Thank you!";
                string subject = "Information about payment";

                DateTime now = DateTime.Now;

                var query = $"UPDATE warehouse SET status = 'paid', paid_data = NOW(), status_checked = '{Classes.Session.Admin_Login}' WHERE id = '{pack_id}' ";

                Database.Update(query);

                Classes.Send_Mail.Mail("piotr.murdzia.csharp.testy@gmail.com", User_Email, message, subject);

                if (pointer == 2)
                    // Update Display_DataGridView
                    Display_DataGridView.DataSource = Database.Load_Unpaied_Packs_List();

                MessageBox.Show($"Mail about the payment has been sent to the address: {User_Email}");
            }   
        }
        public void Update_As_Delivered()
        {
            // Copy pack id
            string pack_id = Display_DataGridView.CurrentRow.Cells[0].Value.ToString();
            // Copy UID
            string UID = Display_DataGridView.CurrentRow.Cells[1].Value.ToString();
            // Copy pack name
            string name = Display_DataGridView.CurrentRow.Cells[20].Value.ToString();

            string User_Email = null;

            // Find User e-mail
            foreach (var user in PC_Admin_Panel.Core.Process.Users_list)
            {
                if (UID.ToString() == user.Uid.ToString())
                    User_Email = user.Email;
            }

            if (User_Email == null)
                MessageBox.Show("We can't find User in our Database!");
            else
            {
                string message = $"We just delivered your pack with \"<b>{name}</b>\" (pack id: <b>{pack_id})</b> <br /> Thank for shopping in our shop!";
                string subject = "Information about delivered";
                DateTime now = DateTime.Now;

                var query = $"UPDATE warehouse SET position = 'delivered', delivered = NOW(), delivered_checked = '{Classes.Session.Admin_Login}' WHERE id = '{pack_id}'";

                Database.Update(query);

                Classes.Send_Mail.Mail("piotr.murdzia.csharp.testy@gmail.com", User_Email, message, subject);

                if (pointer == 2)
                    // Update Display_DataGridView
                    Display_DataGridView.DataSource = Database.Load_Unpaied_Packs_List();
                if (pointer == 3)
                    // Update Display_DataGridView
                    Display_DataGridView.DataSource = Database.Load_Undelivered_Packs_List();

                MessageBox.Show($"Mail with information about delivery of the parcel was sent to the address: {User_Email}");
            }
            

        }



        /// <summary>
        /// Method close aplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create DialogResult to confirm our exit from aplication
            DialogResult confirm = MessageBox.Show("Do you wont to exit?", "Exit", MessageBoxButtons.YesNo);

            // If confirm = true
            // Close all application
            if (confirm == DialogResult.Yes)
            {
                    Environment.Exit(0);
            }
            // Else close DialogResult
            else if(confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Method remove pointed admin
        /// </summary>
        private void Remove_Admin()
        {

            // Check if row exists
            // Check if we try delete yourself
            if (Convert.ToString(Display_DataGridView.CurrentRow.Cells[0].Value.ToString()) != null || Display_DataGridView.CurrentRow.Cells[0].Value.ToString() != Classes.Session.Admin_Login)
            {
                // Prepare query
                string query = $"DELETE FROM admins WHERE login = '{Display_DataGridView.CurrentRow.Cells[0].Value.ToString()}'";

                // Create dialog to confirm our choice
                DialogResult confirm = MessageBox.Show($"Do you wont to delete {Display_DataGridView.CurrentRow.Cells[0].Value.ToString()}?", "Remove admin", MessageBoxButtons.YesNo);

                // if you're sure
                if (confirm == DialogResult.Yes)
                {
                    // Remove admin
                    Database.Delete(query);
                }
            }
            else
            {
                MessageBox.Show("You must select one row", "Delete admin error");
            }
        }

    }
}

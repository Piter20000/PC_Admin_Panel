namespace PC_Admin_Panel.Forms
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logged_As_Label = new System.Windows.Forms.Label();
            this.Display_DataGridView = new System.Windows.Forms.DataGridView();
            this.Packs_List_Button = new System.Windows.Forms.Button();
            this.Unpaid_Pack_Button = new System.Windows.Forms.Button();
            this.Undelivered_Packs_Button = new System.Windows.Forms.Button();
            this.Users_List_Button = new System.Windows.Forms.Button();
            this.Admins_List_Button = new System.Windows.Forms.Button();
            this.Load_PC_Data_Button = new System.Windows.Forms.Button();
            this.Load_IP_Data_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Paid_Button = new System.Windows.Forms.Button();
            this.Delivered_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Display_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Logged_As_Label
            // 
            this.Logged_As_Label.AutoSize = true;
            this.Logged_As_Label.Location = new System.Drawing.Point(588, 24);
            this.Logged_As_Label.Name = "Logged_As_Label";
            this.Logged_As_Label.Size = new System.Drawing.Size(98, 20);
            this.Logged_As_Label.TabIndex = 0;
            this.Logged_As_Label.Text = "Logged as:";
            // 
            // Display_DataGridView
            // 
            this.Display_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Display_DataGridView.Location = new System.Drawing.Point(207, 88);
            this.Display_DataGridView.Name = "Display_DataGridView";
            this.Display_DataGridView.Size = new System.Drawing.Size(1176, 350);
            this.Display_DataGridView.TabIndex = 1;
            this.Display_DataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Display_DataGridView_MouseClick);
            // 
            // Packs_List_Button
            // 
            this.Packs_List_Button.AutoSize = true;
            this.Packs_List_Button.Location = new System.Drawing.Point(24, 88);
            this.Packs_List_Button.Name = "Packs_List_Button";
            this.Packs_List_Button.Size = new System.Drawing.Size(167, 30);
            this.Packs_List_Button.TabIndex = 2;
            this.Packs_List_Button.Text = "Packs";
            this.Packs_List_Button.UseVisualStyleBackColor = true;
            this.Packs_List_Button.Click += new System.EventHandler(this.Packs_List_Button_Click);
            // 
            // Unpaid_Pack_Button
            // 
            this.Unpaid_Pack_Button.AutoSize = true;
            this.Unpaid_Pack_Button.Location = new System.Drawing.Point(24, 124);
            this.Unpaid_Pack_Button.Name = "Unpaid_Pack_Button";
            this.Unpaid_Pack_Button.Size = new System.Drawing.Size(167, 30);
            this.Unpaid_Pack_Button.TabIndex = 2;
            this.Unpaid_Pack_Button.Text = "Unpaid Packs";
            this.Unpaid_Pack_Button.UseVisualStyleBackColor = true;
            this.Unpaid_Pack_Button.Click += new System.EventHandler(this.Unpaid_Pack_Button_Click);
            // 
            // Undelivered_Packs_Button
            // 
            this.Undelivered_Packs_Button.AutoSize = true;
            this.Undelivered_Packs_Button.Location = new System.Drawing.Point(24, 160);
            this.Undelivered_Packs_Button.Name = "Undelivered_Packs_Button";
            this.Undelivered_Packs_Button.Size = new System.Drawing.Size(167, 30);
            this.Undelivered_Packs_Button.TabIndex = 2;
            this.Undelivered_Packs_Button.Text = "Undelivered Packs";
            this.Undelivered_Packs_Button.UseVisualStyleBackColor = true;
            this.Undelivered_Packs_Button.Click += new System.EventHandler(this.Undelivered_Packs_Button_Click);
            // 
            // Users_List_Button
            // 
            this.Users_List_Button.AutoSize = true;
            this.Users_List_Button.Location = new System.Drawing.Point(24, 196);
            this.Users_List_Button.Name = "Users_List_Button";
            this.Users_List_Button.Size = new System.Drawing.Size(167, 30);
            this.Users_List_Button.TabIndex = 2;
            this.Users_List_Button.Text = "Users";
            this.Users_List_Button.UseVisualStyleBackColor = true;
            this.Users_List_Button.Click += new System.EventHandler(this.Users_List_Button_Click);
            // 
            // Admins_List_Button
            // 
            this.Admins_List_Button.AutoSize = true;
            this.Admins_List_Button.Location = new System.Drawing.Point(24, 232);
            this.Admins_List_Button.Name = "Admins_List_Button";
            this.Admins_List_Button.Size = new System.Drawing.Size(167, 30);
            this.Admins_List_Button.TabIndex = 2;
            this.Admins_List_Button.Text = "Admins";
            this.Admins_List_Button.UseVisualStyleBackColor = true;
            this.Admins_List_Button.Click += new System.EventHandler(this.Admins_List_Button_Click);
            // 
            // Load_PC_Data_Button
            // 
            this.Load_PC_Data_Button.AutoSize = true;
            this.Load_PC_Data_Button.Location = new System.Drawing.Point(24, 268);
            this.Load_PC_Data_Button.Name = "Load_PC_Data_Button";
            this.Load_PC_Data_Button.Size = new System.Drawing.Size(167, 30);
            this.Load_PC_Data_Button.TabIndex = 2;
            this.Load_PC_Data_Button.Text = "PC data";
            this.Load_PC_Data_Button.UseVisualStyleBackColor = true;
            this.Load_PC_Data_Button.Click += new System.EventHandler(this.Load_PC_Data_Button_Click);
            // 
            // Load_IP_Data_Button
            // 
            this.Load_IP_Data_Button.AutoSize = true;
            this.Load_IP_Data_Button.Location = new System.Drawing.Point(24, 304);
            this.Load_IP_Data_Button.Name = "Load_IP_Data_Button";
            this.Load_IP_Data_Button.Size = new System.Drawing.Size(167, 30);
            this.Load_IP_Data_Button.TabIndex = 2;
            this.Load_IP_Data_Button.Text = "IP data";
            this.Load_IP_Data_Button.UseVisualStyleBackColor = true;
            this.Load_IP_Data_Button.Click += new System.EventHandler(this.Load_IP_Data_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.AutoSize = true;
            this.Update_Button.Enabled = false;
            this.Update_Button.Location = new System.Drawing.Point(207, 516);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(167, 30);
            this.Update_Button.TabIndex = 2;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.AutoSize = true;
            this.Delete_Button.Enabled = false;
            this.Delete_Button.Location = new System.Drawing.Point(207, 480);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(167, 30);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.AutoSize = true;
            this.Insert_Button.Enabled = false;
            this.Insert_Button.Location = new System.Drawing.Point(207, 444);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(167, 30);
            this.Insert_Button.TabIndex = 2;
            this.Insert_Button.Text = "Insert";
            this.Insert_Button.UseVisualStyleBackColor = true;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Paid_Button
            // 
            this.Paid_Button.AutoSize = true;
            this.Paid_Button.Enabled = false;
            this.Paid_Button.Location = new System.Drawing.Point(207, 552);
            this.Paid_Button.Name = "Paid_Button";
            this.Paid_Button.Size = new System.Drawing.Size(167, 30);
            this.Paid_Button.TabIndex = 2;
            this.Paid_Button.Text = "Paid";
            this.Paid_Button.UseVisualStyleBackColor = true;
            this.Paid_Button.Click += new System.EventHandler(this.Paid_Button_Click);
            // 
            // Delivered_Button
            // 
            this.Delivered_Button.AutoSize = true;
            this.Delivered_Button.Enabled = false;
            this.Delivered_Button.Location = new System.Drawing.Point(207, 588);
            this.Delivered_Button.Name = "Delivered_Button";
            this.Delivered_Button.Size = new System.Drawing.Size(167, 30);
            this.Delivered_Button.TabIndex = 2;
            this.Delivered_Button.Text = "Delivered";
            this.Delivered_Button.UseVisualStyleBackColor = true;
            this.Delivered_Button.Click += new System.EventHandler(this.Delivered_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1463, 782);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Delivered_Button);
            this.Controls.Add(this.Paid_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Load_IP_Data_Button);
            this.Controls.Add(this.Load_PC_Data_Button);
            this.Controls.Add(this.Admins_List_Button);
            this.Controls.Add(this.Users_List_Button);
            this.Controls.Add(this.Undelivered_Packs_Button);
            this.Controls.Add(this.Unpaid_Pack_Button);
            this.Controls.Add(this.Packs_List_Button);
            this.Controls.Add(this.Display_DataGridView);
            this.Controls.Add(this.Logged_As_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main_Form";
            this.Text = "Main_Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Display_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logged_As_Label;
        private System.Windows.Forms.DataGridView Display_DataGridView;
        private System.Windows.Forms.Button Packs_List_Button;
        private System.Windows.Forms.Button Unpaid_Pack_Button;
        private System.Windows.Forms.Button Undelivered_Packs_Button;
        private System.Windows.Forms.Button Users_List_Button;
        private System.Windows.Forms.Button Admins_List_Button;
        private System.Windows.Forms.Button Load_PC_Data_Button;
        private System.Windows.Forms.Button Load_IP_Data_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button Paid_Button;
        private System.Windows.Forms.Button Delivered_Button;
    }
}
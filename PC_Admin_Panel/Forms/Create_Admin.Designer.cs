namespace PC_Admin_Panel.Forms
{
    partial class Create_Admin
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
            this.Create_Button = new System.Windows.Forms.Button();
            this.Login_Textbox = new System.Windows.Forms.TextBox();
            this.Password1_Textbox = new System.Windows.Forms.TextBox();
            this.Password2_Textbox = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Password1_Label = new System.Windows.Forms.Label();
            this.Password2_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_Button
            // 
            this.Create_Button.AutoSize = true;
            this.Create_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Create_Button.Location = new System.Drawing.Point(88, 231);
            this.Create_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(130, 46);
            this.Create_Button.TabIndex = 0;
            this.Create_Button.Text = "Create ";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Login_Textbox
            // 
            this.Login_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_Textbox.Location = new System.Drawing.Point(71, 79);
            this.Login_Textbox.Margin = new System.Windows.Forms.Padding(5);
            this.Login_Textbox.Name = "Login_Textbox";
            this.Login_Textbox.Size = new System.Drawing.Size(164, 26);
            this.Login_Textbox.TabIndex = 1;
            // 
            // Password1_Textbox
            // 
            this.Password1_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password1_Textbox.Location = new System.Drawing.Point(71, 137);
            this.Password1_Textbox.Margin = new System.Windows.Forms.Padding(5);
            this.Password1_Textbox.Name = "Password1_Textbox";
            this.Password1_Textbox.Size = new System.Drawing.Size(164, 26);
            this.Password1_Textbox.TabIndex = 1;
            // 
            // Password2_Textbox
            // 
            this.Password2_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password2_Textbox.Location = new System.Drawing.Point(71, 195);
            this.Password2_Textbox.Margin = new System.Windows.Forms.Padding(5);
            this.Password2_Textbox.Name = "Password2_Textbox";
            this.Password2_Textbox.Size = new System.Drawing.Size(164, 26);
            this.Password2_Textbox.TabIndex = 1;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Location = new System.Drawing.Point(79, 53);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(53, 20);
            this.Login_Label.TabIndex = 2;
            this.Login_Label.Text = "Login";
            // 
            // Password1_Label
            // 
            this.Password1_Label.AutoSize = true;
            this.Password1_Label.Location = new System.Drawing.Point(79, 111);
            this.Password1_Label.Name = "Password1_Label";
            this.Password1_Label.Size = new System.Drawing.Size(86, 20);
            this.Password1_Label.TabIndex = 2;
            this.Password1_Label.Text = "Password";
            // 
            // Password2_Label
            // 
            this.Password2_Label.AutoSize = true;
            this.Password2_Label.Location = new System.Drawing.Point(79, 169);
            this.Password2_Label.Name = "Password2_Label";
            this.Password2_Label.Size = new System.Drawing.Size(149, 20);
            this.Password2_Label.TabIndex = 2;
            this.Password2_Label.Text = "Repeat password";
            // 
            // Create_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(306, 326);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.Password2_Label);
            this.Controls.Add(this.Password1_Label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Password2_Textbox);
            this.Controls.Add(this.Password1_Textbox);
            this.Controls.Add(this.Login_Textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Create_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.TextBox Login_Textbox;
        private System.Windows.Forms.TextBox Password1_Textbox;
        private System.Windows.Forms.TextBox Password2_Textbox;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Password1_Label;
        private System.Windows.Forms.Label Password2_Label;
    }
}
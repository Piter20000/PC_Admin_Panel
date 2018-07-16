namespace PC_Admin_Panel.Forms
{
    partial class Login_Form
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
            this.Login_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_TxtBox = new System.Windows.Forms.TextBox();
            this.Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Location = new System.Drawing.Point(93, 5);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(53, 20);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Login";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(76, 59);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(86, 20);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // Login_TxtBox
            // 
            this.Login_TxtBox.Location = new System.Drawing.Point(16, 28);
            this.Login_TxtBox.Name = "Login_TxtBox";
            this.Login_TxtBox.Size = new System.Drawing.Size(206, 26);
            this.Login_TxtBox.TabIndex = 2;
            // 
            // Password_TxtBox
            // 
            this.Password_TxtBox.Location = new System.Drawing.Point(14, 82);
            this.Password_TxtBox.Name = "Password_TxtBox";
            this.Password_TxtBox.Size = new System.Drawing.Size(210, 26);
            this.Password_TxtBox.TabIndex = 3;
            // 
            // Login_Button
            // 
            this.Login_Button.AutoSize = true;
            this.Login_Button.Location = new System.Drawing.Point(79, 114);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(81, 30);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(238, 151);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_TxtBox);
            this.Controls.Add(this.Login_TxtBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Login_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Login_TxtBox;
        private System.Windows.Forms.TextBox Password_TxtBox;
        private System.Windows.Forms.Button Login_Button;
    }
}
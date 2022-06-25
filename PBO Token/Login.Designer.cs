namespace PBO_Token
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.Username_Text = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(532, 235);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(100, 39);
            this.button_login.TabIndex = 11;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(532, 209);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password  :";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(532, 184);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 7;
            // 
            // Username_Text
            // 
            this.Username_Text.AutoSize = true;
            this.Username_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text.Location = new System.Drawing.Point(436, 184);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(86, 16);
            this.Username_Text.TabIndex = 6;
            this.Username_Text.Text = "Username :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfo.Location = new System.Drawing.Point(445, 260);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(2, 15);
            this.lblInfo.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 488);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.Username_Text);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1050, 488);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label Username_Text;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

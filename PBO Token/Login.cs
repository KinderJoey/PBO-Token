using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Token
{
    public partial class Login : UserControl
    {
        
        Form1 objParent;
        public Login()
        {
            InitializeComponent();
        }
        public Login(Form1 p_parent)
        {
            InitializeComponent();
            objParent = p_parent;
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "a" && textBox_Password.Text == "a")
            {
                lblInfo.Text = "";
                textBox_Username.Text = "";
                textBox_Password.Text = "";
                this.Visible = false;
                MessageBox.Show("Username atau password benar...", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objParent.showForm();

            }
            else if (textBox_Username.Text == "galang" && textBox_Password.Text == "admingalang")
            {
                lblInfo.Text = "";
                textBox_Username.Text = "";
                textBox_Password.Text = "";
                this.Visible = false;
                MessageBox.Show("Username atau password benar...", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objParent.showForm();


            }
            else 
            {
                lblInfo.Text = "Username atau password salah...";
                DialogResult result;
                result = MessageBox.Show("Username atau password salah... // ingin mencoba lagi??...", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
                
            
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelutama_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

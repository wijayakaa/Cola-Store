using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "admin")
            {
                HomePage home = new HomePage();
                home.Show();
                this.Hide();

            }
            else if (username == "a" && password == "a")
            {
                HomePage home = new HomePage();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah. Silakan coba lagi.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}

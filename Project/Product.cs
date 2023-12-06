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
    public partial class Product : Form
    {
        public static List<Product_Class> cart = new List<Product_Class>();

        public Product()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Hide();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Product_Class Cocacola1 = new Product_Class
                {
                    productImage = Properties.Resources.menu1,
                    productName = "Cocacola kecil",
                    productPrice = 3500,
                };
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola sedang",
                productPrice = 5800,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola besar",
                productPrice = 15000,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola premium",
                productPrice = 7500,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola silver",
                productPrice = 9500,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola limited",
                productPrice = 7500,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola classic",
                productPrice = 5300,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola zero sugar",
                productPrice = 5800,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola zero sugar",
                productPrice = 6200,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola",
                productPrice = 6200,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola vanilla",
                productPrice = 10500,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Product_Class Cocacola1 = new Product_Class
            {
                productImage = Properties.Resources.menu1,
                productName = "Cocacola lemonade",
                productPrice = 13500,
            };
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menambahkan Product ke cart?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                cart.Add(Cocacola1);
                MessageBox.Show("Cocacola telah ditambahkan ke cart!");
            }
            else
            {

            }
        }
    }
}

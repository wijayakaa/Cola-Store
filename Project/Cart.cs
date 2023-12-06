using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Project
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            DisplayCartContents();
        }

        private void DisplayCartContents()
        {
            List<Product_Class> cartContents = Product.cart;

            int panelTop = 90;

            foreach (var product in cartContents)
            {
                Panel panel = new Panel();
                Label nameLabel = new Label();
                Label priceLabel = new Label();
                PictureBox pictureBox = new PictureBox();

                panel.BackColor = System.Drawing.SystemColors.ButtonFace;
                panel.Location = new System.Drawing.Point(157, panelTop);
                panel.Name = "panel" + cartContents.IndexOf(product);
                panel.Size = new System.Drawing.Size(200, 246);
                panel.TabIndex = 0;

                nameLabel.AutoSize = true;
                nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameLabel.Location = new System.Drawing.Point(3, 117);
                nameLabel.Name = "label7";
                nameLabel.Size = new System.Drawing.Size(149, 26);
                nameLabel.Text = product.productName;

                priceLabel.AutoSize = true;
                priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                priceLabel.ForeColor = System.Drawing.Color.IndianRed;
                priceLabel.Location = new System.Drawing.Point(4, 160);
                priceLabel.Name = "label19";
                priceLabel.Size = new System.Drawing.Size(55, 20);
                priceLabel.Text = "Harga";
                priceLabel.Text = product.productPrice.ToString();

                pictureBox.Location = new System.Drawing.Point(0, 0);
                pictureBox.Name = "pictureBox2";
                pictureBox.Size = new System.Drawing.Size(200, 114);
                pictureBox.TabStop = false;
                pictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
                pictureBox.Image = product.productImage;

                panel.Controls.Add(nameLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(pictureBox);

                this.Controls.Add(panel);

                panelTop += panel.Height + 10;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in cartContents)
            {
                Panel panel2 = new Panel(); // Membuat panel2 untuk setiap produk

                PictureBox pictureBox = new PictureBox();
                Label nameLabel = new Label();
                Label priceLabel = new Label();

                pictureBox.Location = new System.Drawing.Point(0, 0);
                pictureBox.Name = "pictureBox2";
                pictureBox.Size = new System.Drawing.Size(200, 114);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.TabStop = false;
                pictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
                pictureBox.Image = product.productImage;

                nameLabel.AutoSize = true;
                nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameLabel.Location = new System.Drawing.Point(10, pictureBox.Bottom + 10); // Sesuaikan koordinat
                nameLabel.Name = "label7";
                nameLabel.Size = new System.Drawing.Size(149, 26);
                nameLabel.Text = product.productName;

                priceLabel.AutoSize = true;
                priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                priceLabel.ForeColor = System.Drawing.Color.IndianRed;
                priceLabel.Location = new System.Drawing.Point(10, nameLabel.Bottom + 5); // Sesuaikan koordinat
                priceLabel.Name = "label19";
                priceLabel.Size = new System.Drawing.Size(55, 20);
                priceLabel.Text = "Harga: " + product.productPrice.ToString();

                panel2.Location = new System.Drawing.Point(3, 3);
                panel2.Name = "panel2";
                panel2.Size = new System.Drawing.Size(181, 209);

                // Menambahkan kontrol ke dalam panel2
                panel2.Controls.Add(pictureBox);
                panel2.Controls.Add(nameLabel);
                panel2.Controls.Add(priceLabel);

                // Menambahkan panel2 ke dalam flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(panel2);
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cocacola telah di berhasil di beli!");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Product_Class
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public Image productImage { get; set; }
        public Button removeButton { get; set; }
    }
}

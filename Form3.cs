using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_DVD_Shop
{
    public partial class Form3 : Form
    {
        double total = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbCart.DataSource = Common.boughtItems;

            foreach(Item item in Common.boughtItems)
            {
                total += item.Price;
            }

            lblTotal.Text = total.ToString();

        }
    }
}

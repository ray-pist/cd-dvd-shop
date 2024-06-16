using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CD_DVD_Shop
{
    public partial class Form3 : Form
    {
        static double total = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbCart.DataSource = Common.boughtItems;
            getTotal(Common.boughtItems);

            lblTotal.Text = '$' + total.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Common.boughtItems.RemoveAt(lbCart.SelectedIndex);
            getTotal(Common.boughtItems);

            lbCart.DataSource = null;
            lbCart.DataSource = Common.boughtItems;
            lblTotal.Text = '$' + total.ToString();
        }

        private double getTotal(List<Item> cart)
        {
            total = 0;

            foreach (Item item in Common.boughtItems)
            {
                total += item.Price;
            }

            return total;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Common.boughtItems.Count == 0)
            {
                MessageBox.Show("Nemate ništa u košarici.");
            }
            else
            {
                MessageBox.Show("Ukupni iznos za platiti je $" + total.ToString() + ". Hvala na dolasku i dođite nam opet!");
                Application.Exit();
            }
        }

        
    }
}

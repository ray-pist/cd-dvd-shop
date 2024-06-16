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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("games");
            form2.ShowDialog();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("music");
            form2.ShowDialog();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("movies");
            form2.ShowDialog();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Common.boughtItems.Count < 1)
            {
                MessageBox.Show("Prazna košarica. Kupi nešto pa se vrati.");
            }
            else
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
        }
    }
}

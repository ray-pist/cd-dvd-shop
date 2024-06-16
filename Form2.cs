using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_DVD_Shop
{
    public partial class Form2 : Form
    {
        string typeOfProduct = null;
        static List<Item> listOfMoviesInListBox = new List<Item>();
        static List<Item> listOfGamesInListBox = new List<Item>();
        static List<Item> listOfMusicInListBox = new List<Item>();
        List<Item> activeList = new List<Item>();


        public Form2(string type)
        {
            this.typeOfProduct = type;
            InitializeComponent();

            if (typeOfProduct.Equals("games"))
            {
                this.BackgroundImage = Properties.Resources.games;
                setActive(lblGames);
            }
            else if (typeOfProduct.Equals("movies"))
            {
                this.BackgroundImage = Properties.Resources.movies;
                setActive(lblMovies);
            }
            else if (typeOfProduct.Equals("music"))   
            {
                this.BackgroundImage = Properties.Resources.music;
                setActive(lblMusic);
            }

            this.BackgroundImageLayout = ImageLayout.Stretch;

            ReadFileLinesToList("../../games.txt", listOfGamesInListBox);
            ReadFileLinesToList("../../movies.txt", listOfMoviesInListBox);
            ReadFileLinesToList("../../music.txt", listOfMusicInListBox);

            lbItems.DataSource = typeOfProduct.Equals("games") ? listOfGamesInListBox 
                                 : (typeOfProduct.Equals("movies") ? listOfMoviesInListBox 
                                 : listOfMusicInListBox);

            activeList = lbItems.DataSource as List<Item>;
        }

        private void lblGames_Click(object sender, EventArgs e)
        {
            setActive(lblGames);
            setInactive(lblMusic);
            setInactive(lblMovies);
            this.BackgroundImage = Properties.Resources.games;

            lbItems.DataSource = null;
            lbItems.DataSource = activeList = listOfGamesInListBox;
        }

        private void lblMusic_Click(object sender, EventArgs e)
        {
            setActive(lblMusic);
            setInactive(lblGames);
            setInactive(lblMovies);
            this.BackgroundImage = Properties.Resources.music;

            lbItems.DataSource = null;
            lbItems.DataSource = activeList = listOfMusicInListBox;
        }

        private void lblMovies_Click(object sender, EventArgs e)
        {
            setActive(lblMovies);
            setInactive(lblGames);
            setInactive(lblMusic);
            this.BackgroundImage = Properties.Resources.movies;

            lbItems.DataSource = null;
            lbItems.DataSource = activeList = listOfMoviesInListBox;
        }

        private void setActive(Label lbl)
        {
            lbl.BackColor = Color.White;
            lbl.ForeColor = Color.Black;
        }

        private void setInactive(Label lbl)
        {
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
        }

        private void ReadFileLinesToList(string filePath, List<Item> list)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(new Item(line));
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbItems.SelectedValue.ToString());
            Common.boughtItems.Add(new Item(lbItems.SelectedValue.ToString()));
            activeList.RemoveAt(lbItems.SelectedIndex);

            lbItems.DataSource = null;
            lbItems.DataSource = activeList;
        }
    }
}

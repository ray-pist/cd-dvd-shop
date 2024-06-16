using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_DVD_Shop
{
    public class Item
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; }

        public Item(string author, string name, double price) 
        { 
            this.Name = name;
            this.Author = author;
            this.Price = price;
        }

        public Item(string line) 
        {
            List<string> lineList = line.Split('|').ToList();
            this.Name = lineList.ElementAt(0);
            this.Author = lineList.ElementAt(1);
            this.Price = Double.Parse(lineList.ElementAt(2).Substring(2));

        }

        public override string ToString()
        {
            return this.Name + " | " + this.Author + " | $" + this.Price;
        }
    }
}

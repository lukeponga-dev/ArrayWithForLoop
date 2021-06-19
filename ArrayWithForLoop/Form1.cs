using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayWithForLoop
{
    public partial class Form1 : Form
    {

     
        public Form1()
        {
            InitializeComponent();




        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            lbxNames.Items.Clear();
            // Create an array of items
            string[] names = {"Arthur", "Daniel", "Jane", "Darren", "Ethan", "Jeff", "Judah", "Kyle","Sonya", "Josh", "Keum"};
            //using for loop
            foreach (string name in names)
            {
                lbxNames.Items.Add(name);
            }

            // create random number generator 
            Random rand = new Random();
            //run a random number and pass it to winner. note names.Length has -1 on it
            int winner = rand.Next(0, names.Length - 1);
            // put the winner number into the array to get back the name
            lblWinner.Text = "And the winner is..." + names[winner];

            //Add winner to listbox
            lbxWinners.Items.Add(names[winner]);
        }
    }
}

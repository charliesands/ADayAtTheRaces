using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] guy = new Guy[3];
        Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = dogPictureBox1,
                StartingPosition = dogPictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox1.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = dogPictureBox2,
                StartingPosition = dogPictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox2.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = dogPictureBox3,
                StartingPosition = dogPictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox3.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = dogPictureBox4,
                StartingPosition = dogPictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox4.Width,
                Randomizer = MyRandomizer
            };



        }

        

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void joeBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

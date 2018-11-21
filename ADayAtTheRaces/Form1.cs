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
        Greyhound[] greyhoundArray = new Greyhound[4];
        Guy[] guy = new Guy[3];
        Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            greyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = dogPictureBox1,
                StartingPosition = dogPictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox1.Width,
                Randomizer = MyRandomizer
            };

            greyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = dogPictureBox2,
                StartingPosition = dogPictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox2.Width,
                Randomizer = MyRandomizer
            };

            greyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = dogPictureBox3,
                StartingPosition = dogPictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox3.Width,
                Randomizer = MyRandomizer
            };

            greyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = dogPictureBox4,
                StartingPosition = dogPictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - dogPictureBox4.Width,
                Randomizer = MyRandomizer
            };

            guy[0] = new Guy() { Cash = 50, MyLabel = joeBetLabel, MyRadioButton = joeRadioButton, Name = "Joe" };
            guy[1] = new Guy() { Cash = 75, MyLabel = bobBetLabel, MyRadioButton = bobRadioButton, Name = "Bob" };
            guy[2] = new Guy() { Cash = 45, MyLabel = alBetLabel, MyRadioButton = alRadioButton, Name = "Al" };

            minimumBetLabel.Text = "Minimum bet: " + cashBet.Minimum + "bucks";

            refreshGuyState();
        }

        public void refreshGuyState()
        {
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].ClearBet();
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guy[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guy[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guy[2].Name;         
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void joeBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                guy[0].PlaceBet((int)cashBet.Value, (int)dogChoice.Value);
            }
            if (bobRadioButton.Checked)
            {
                guy[1].PlaceBet((int)cashBet.Value, (int)dogChoice.Value);
            }
            if (alRadioButton.Checked)
            {
                guy[2].PlaceBet((int)cashBet.Value, (int)dogChoice.Value);
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winningDog = 0;

            for (int i = 0; i < greyhoundArray.Length; i++)
            {
                if (greyhoundArray[i].Run())
                {
                    timer1.Stop();
                    winningDog = i + 1;
                    MessageBox.Show("Dog #" + winningDog + " won the race!");

                    for (int j = 0; j < guy.Length; j++)
                    {
                        guy[j].Collect(winningDog);
                    }

                    refreshGuyState();
                    betBox.Enabled = true;
                    break;
                }
            }
        }
    }
}

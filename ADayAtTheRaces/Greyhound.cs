﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            Location += Randomizer.Next(4);
            MyPictureBox.Left = StartingPosition + Location;
            MyPictureBox.Refresh();

            if (MyPictureBox.Left >= RacetrackLength - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}

using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class race
    {
        public int Run;
        public Random Random;
        public int RacerGO;
        public int cyclerun;
        public PictureBox MyPictureBox = null;

        public void CycleStart()
        {
            Run = 0;
            MyPictureBox.Left = RacerGO;
        }
        public bool Runcycle()
        {
            var A = Random.Next(1, 22);
            Run += A;
            MyPictureBox.Left = RacerGO + Run;

            if (MyPictureBox.Left >= cyclerun)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
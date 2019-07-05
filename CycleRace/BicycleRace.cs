using System;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class CycleRace : Form
    {
        race[] objRacers = new race[4];
        Gamblers[] ObjPlayers = new Gamblers[3];
        Random myRandom = new Random();
       
        public CycleRace()
        {
            InitializeComponent();

            objRacers[0] = new race()
            {
                MyPictureBox = PBbicycle1,
                RacerGO = PBbicycle1.Left,
                cyclerun = racetrack.Width - PBbicycle1.Width,
                Random = myRandom
            };
            objRacers[1] = new race()
            {
                MyPictureBox = PBbicycle2,
                RacerGO = PBbicycle2.Left,
                cyclerun = racetrack.Width - PBbicycle2.Width,
                Random = myRandom
            };
            objRacers[2] = new race()
            {
                MyPictureBox = PBbicycle3,
                RacerGO = PBbicycle3.Left,
                cyclerun = racetrack.Width - PBbicycle3.Width,
                Random = myRandom
            };
            objRacers[3] = new race()
            {
                MyPictureBox = PBbicycle4,
                RacerGO = PBbicycle4.Left,
                cyclerun = racetrack.Width - PBbicycle4.Width,
                Random = myRandom
            };
            //Racers of the cycle
            ObjPlayers[0] = new Gamblers()
            {
                Amount = 50,
                BetPlaced = null,
                BeterLabel = LucyLB,
                BetterRadio = LucyRB,
                PlayerName = "Lucy"
            };
            ObjPlayers[1] = new Gamblers()
            {
                Amount = 50,
                BetPlaced = null,
                BeterLabel = SarahLB,
                BetterRadio = SarahRB,
                PlayerName = "Sarah"
            };
            ObjPlayers[2] = new Gamblers()
            {
                Amount = 50,
                BetPlaced = null,
                BeterLabel = SamLB,
                BetterRadio = SamRB,
                PlayerName = "Sam"
            };
            //There are three players who bet on the cycles.
            foreach (Gamblers guy in ObjPlayers)
            {
                guy.BetPlaced = new Bet();
                guy.ClearALL();
                guy.Showlabel();
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gamble.Enabled = false;
        }

        private void SimerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = ObjPlayers[0].PlayerName;
        }

        private void GillRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = ObjPlayers[1].PlayerName;
        }

        private void MalkeetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = ObjPlayers[2].PlayerName;
        }

        private void Bet_Click(object sender, EventArgs e)
        {
            if (ObjPlayers[0].BetterRadio.Checked)
            {
                if (ObjPlayers[0].Placebet((int)betIncre.Value, (int)Chooseracer.Value))
                {
                    ObjPlayers[0].Showlabel();
                }
            }
            if (ObjPlayers[1].BetterRadio.Checked)
            {
                if (ObjPlayers[1].Placebet((int)betIncre.Value, (int)Chooseracer.Value))
                {
                    ObjPlayers[1].Showlabel();
                }
            }
            if (ObjPlayers[2].BetterRadio.Checked)
            {
                if (ObjPlayers[2].Placebet((int)betIncre.Value, (int)Chooseracer.Value))
                {
                    ObjPlayers[2].Showlabel();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (objRacers[i].Runcycle())
                {
                    var winner = i + 1;
                    timer1.Stop();
                    MessageBox.Show($@"Cycleist number {winner} wins!", @"The Winner is");

                    foreach (Gamblers guy in ObjPlayers)
                    {
                        guy.betmoneywin(winner);
                    }

                    foreach (race cycle in objRacers)
                    {
                        cycle.CycleStart();
                    }

                    gamble.Enabled = true;
                    break;
                }
            }
        }

        private void LucyLB_Click(object sender, EventArgs e)
        {

        }

        private void gamble_Enter(object sender, EventArgs e)
        {

        }

        private void SarahLB_Click(object sender, EventArgs e)
        {

        }

        private void racetrack_Click(object sender, EventArgs e)
        {

        }
    }
}

using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Gamblers
    {
        public RadioButton BetterRadio;
        public Label BeterLabel;
        public Bet BetPlaced;
        public string PlayerName;
        
        public int Amount;


        public bool Placebet(int Amount, int Firstracer) 
        {
            BetPlaced = new Bet() { Amount = Amount, money = this, Cycle = Firstracer };

            if (Amount <= this.Amount)
            {
                BetPlaced.Amount = Amount;
                BetPlaced.Cycle = Firstracer;
                return true;
            }
            ClearALL();
            Showlabel();
            return false;
        }
        public void Showlabel()
        {
            BeterLabel.Text = BetPlaced.placed_bets(this);
            BetterRadio.Text = $@"{PlayerName} has ${Amount} dollars";
        }
        public void betmoneywin(int winner)
        {
            Amount += BetPlaced.Moneyadd(winner);
            ClearALL();
            Showlabel();
        }
       

        public void ClearALL()
        {
            BetPlaced.Amount = 0;
        }

       
    }
}
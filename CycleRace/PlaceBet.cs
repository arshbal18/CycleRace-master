namespace RacetrackSimulator
{
    public class Bet
    {
        public Gamblers money;
        public int Amount;
        public int Cycle;
        

        public int Moneyadd(int Firstbicycle)
        {
            if (Cycle == Firstbicycle)
            {
                return Amount;
            }
            return Amount * -1;
        }
        public string placed_bets(Gamblers bettor)
        {
            money = bettor;
            if (Amount > 0)
            {
                return $@"{money.PlayerName} places a bet ${Amount} on Racer {Cycle}";
            }
            return $@"{money.PlayerName} neet to place a bet yet";
        }

       
    }
}
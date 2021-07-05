namespace csharpcore
{
    public class Player
    {
        public string Name { get; }
        public int Place { get; private set; }
        public int Purse { get; private set; }
        public bool IsInPenaltyBox { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void SetPlayerInPenaltyBox()
        {
            IsInPenaltyBox = true;
        }

        public void IncrementPurse()
        {
            Purse += 1;
        }

        public void Move(int roll)
        {
            Place = Place + roll;
            if (Place > 11)
                Place = Place - 12;
        }
    }
}
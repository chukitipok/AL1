namespace csharpcore
{
    public abstract class PlayerState
    {
        protected Player _player;

        protected PlayerState(Player player)
        {
            _player = player;
        }

        public abstract PlayerState SetPlayerInPenaltyBox();

        public abstract PlayerState SetPlayerOutOfPenaltyBox();

        public abstract PlayerState IncrementPurse();

        public abstract PlayerState Move(int roll);
    }

    public class PlayerInPenaltyBox : PlayerState
    {
        public PlayerInPenaltyBox(Player player) : base(player)
        {
        }

        public override PlayerState SetPlayerInPenaltyBox()
        {
            return this;
        }

        public override PlayerState SetPlayerOutOfPenaltyBox()
        {
            _player.IsInPenaltyBox = false;

            return new PlayerInGame(_player);
        }

        public override PlayerState IncrementPurse()
        {
            return this;
        }

        public override PlayerState Move(int roll)
        {
            return this;
        }
    }

    public class PlayerInGame : PlayerState
    {
        public PlayerInGame(Player player) : base(player)
        {
        }

        public override PlayerState SetPlayerInPenaltyBox()
        {
            _player.IsInPenaltyBox = true;

            return new PlayerInPenaltyBox(_player);
        }

        public override PlayerState SetPlayerOutOfPenaltyBox()
        {
            return this;
        }

        public override PlayerState IncrementPurse()
        {
            _player.Purse += 1;

            return this;
        }

        public override PlayerState Move(int roll)
        {
            _player.Place = _player.Place + roll;
            if (_player.Place > 11)
                _player.Place = _player.Place - 12;

            return this;
        }
    }

    public class Player
    {
        private PlayerState _state;

        public string Name { get; }
        public int Place { get; set; }
        public int Purse { get; set; }
        public bool IsInPenaltyBox { get; set; }

        public Player(string name)
        {
            Name = name;
            _state = new PlayerInGame(this);
        }

        public void SetPlayerInPenaltyBox()
        {
            _state = _state.SetPlayerInPenaltyBox();
        }

        public void IncrementPurse()
        {
            _state = _state.IncrementPurse();
        }

        public void Move(int roll)
        {
            _state = _state.Move(roll);
        }

        public void SetPlayerOutOfPenaltyBox()
        {
            _state = _state.SetPlayerOutOfPenaltyBox();
        }
    }
}
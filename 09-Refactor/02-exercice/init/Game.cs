using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class Board
    {        
        private readonly List<Player> _players;
        private readonly QuestionDecks _questionDecks;
        private readonly Dictionary<int, QuestionCategory> _placeQuestionCategories;

        private int _currentPlayer;

        public int PlayersCount => _players.Count;
        public Player CurrentPlayer => _players[_currentPlayer];
        
        public Board()
        {
            _placeQuestionCategories = new Dictionary<int, QuestionCategory>
            {
                {0, QuestionCategory.Pop},
                {1, QuestionCategory.Sciences},
                {2, QuestionCategory.Sports},
                {4, QuestionCategory.Pop},
                {5, QuestionCategory.Sciences},
                {6, QuestionCategory.Sports},
                {8, QuestionCategory.Pop},
                {9, QuestionCategory.Sciences},
                {10, QuestionCategory.Sports},
            };
            
            _players = new List<Player>();
            _questionDecks = new QuestionDecks();
        }

        public void AddPlayer(string playerName)
        {
            var player = new Player(playerName);

            _players.Add(player);
        }

        public string DrawCard()
        {
            return _questionDecks.DrawCardFromCategory(CurrentCategory());
        }
        
        public QuestionCategory CurrentCategory()
        {
            var currentPlayerPosition = CurrentPlayer.Place;

            if (_placeQuestionCategories.ContainsKey(currentPlayerPosition))
                return _placeQuestionCategories[currentPlayerPosition];

            return QuestionCategory.Rock;
        }

        public void NextPlayer()
        {
            _currentPlayer++;

            if (_currentPlayer == _players.Count)
                _currentPlayer = 0;
        }
    }

    public class Game
    {
        public event Action<object> Publish;

        private readonly Board _board;

        public Game()
        {
            _board = new Board();
        }

        public void Add(string playerName)
        {
            _board.AddPlayer(playerName);

            Raise(new PlayerAdded(playerName, _board.PlayersCount));
        }

        public void Roll(int roll)
        {
            Raise(new PlayerRolled(_board.CurrentPlayer.Name, roll));

            if (_board.CurrentPlayer.IsInPenaltyBox && IsRollEven(roll))
            {
                Raise(new PlayerStayedPenaltyBox(_board.CurrentPlayer.Name));

                return;
            }

            if (_board.CurrentPlayer.IsInPenaltyBox && !IsRollEven(roll))
            {
                _board.CurrentPlayer.SetPlayerOutOfPenaltyBox();

                Raise(new PlayerLeftPenaltyBox(_board.CurrentPlayer.Name));
            }

            _board.CurrentPlayer.Move(roll);

            Raise(new PlayerMoved(_board.CurrentPlayer.Name, _board.CurrentPlayer.Place, _board.CurrentCategory()));

            AskQuestion();
        }

        public bool CorrectAnswer()
        {
            if (_board.CurrentPlayer.IsInPenaltyBox)
                return true;

            _board.CurrentPlayer.IncrementPurse();

            Raise(new QuestionWasCorrectlyAnswered(_board.CurrentPlayer.Name, _board.CurrentPlayer.Purse));

            return DidPlayerWin();
        }

        public bool WrongAnswer()
        {
            Raise(new QuestionWasIncorrectlyAnswered(_board.CurrentPlayer.Name));

            _board.CurrentPlayer.SetPlayerInPenaltyBox();

            return true;
        }
        
        private void AskQuestion()
        {
            var question = _board.DrawCard();

            Raise(new QuestionAsked(question));
        }

        public void NextPlayer()
        {
            _board.NextPlayer();
        }

        private bool IsRollEven(int roll)
        {
            return roll % 2 == 0;
        }
        
        private bool DidPlayerWin()
        {
            return _board.CurrentPlayer.Purse != 6;
        }

        private void Raise(object evt)
        {
            Publish?.Invoke(evt);
        }
    }
}
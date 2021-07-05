using System;

namespace csharpcore
{
    public class GameConsoleListener
    {
        public void Handle(object evt)
        {
            switch (evt)
            {
                case QuestionAsked e:
                    Console.WriteLine(e.Question);
                    break;
                case PlayerAdded e:
                    Console.WriteLine($"{e.PlayerName} was added");
                    Console.WriteLine($"They are player number {e.PlayersCount}");
                    break;
                case QuestionWasIncorrectlyAnswered e:
                    Console.WriteLine("Question was incorrectly answered");
                    Console.WriteLine($"{e.PlayerName} was sent to the penalty box");
                    break;
                case QuestionWasCorrectlyAnswered e:
                    Console.WriteLine("Answer was corrent!!!!");
                    Console.WriteLine($"{e.PlayerName} now has {e.Gold} Gold Coins.");
                    break;
                case PlayerMoved e:
                    Console.WriteLine($"{e.PlayerName}'s new location is {e.PlayerPlace}");
                    Console.WriteLine($"The category is {e.QuestionCategory}");
                    break;
                case PlayerRolled e:
                    Console.WriteLine($"{e.PlayerName} is the current player");
                    Console.WriteLine($"They have rolled a {e.Roll}");
                    break;
                case PlayerLeftPenaltyBox e:
                    Console.WriteLine($"{e.PlayerName} is not getting out of the penalty box");
                    break;
                case PlayerStayedPenaltyBox e:
                    Console.WriteLine($"{e.PlayerName} is getting out of the penalty box");
                    break;
            }
        }
    }
}
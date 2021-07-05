namespace csharpcore
{
    public record QuestionAsked(string Question);

    public record PlayerMoved(string PlayerName, int PlayerPlace, QuestionCategory QuestionCategory);

    public record PlayerRolled(string PlayerName, int Roll);

    public record PlayerLeftPenaltyBox(string PlayerName);

    public record PlayerStayedPenaltyBox(string PlayerName);

    public record PlayerAdded(string PlayerName, int PlayersCount);

    public record QuestionWasIncorrectlyAnswered(string PlayerName);

    public record QuestionWasCorrectlyAnswered(string PlayerName, int Gold);
}
using System.Collections.Generic;
using System.Linq;

namespace csharpcore
{
    public class QuestionDecks
    {
        private readonly LinkedList<string> _popQuestions = new();
        private readonly LinkedList<string> _scienceQuestions = new();
        private readonly LinkedList<string> _sportsQuestions = new();
        private readonly LinkedList<string> _rockQuestions = new();

        public QuestionDecks()
        {
            _popQuestions = QuestionDeckFactory.Create(QuestionCategory.Pop);
            _scienceQuestions = QuestionDeckFactory.Create(QuestionCategory.Sciences);
            _sportsQuestions = QuestionDeckFactory.Create(QuestionCategory.Sports);
            _rockQuestions = QuestionDeckFactory.Create(QuestionCategory.Rock);
        }

        public string DrawCardFromCategory(QuestionCategory currentCategory)
        {
            var questionDeck = currentCategory switch
            {
                QuestionCategory.Pop => _popQuestions,
                QuestionCategory.Sciences => _scienceQuestions,
                QuestionCategory.Sports => _sportsQuestions,
                _ => _rockQuestions
            };

            var question = questionDeck.First();

            questionDeck.RemoveFirst();

            return question;
        }
    }
    
    public static class QuestionDeckFactory
    {
        public static LinkedList<string> Create(QuestionCategory questionCategory)
        {
            return new(Enumerable.Range(0, 50).Select(x => $"{questionCategory} Question {x}"));
        }
    }
}
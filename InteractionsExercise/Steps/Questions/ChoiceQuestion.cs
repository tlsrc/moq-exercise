using System.Collections.Generic;
using System.Text;
using InteractionsExercise.Steps.Answers;

namespace InteractionsExercise.Steps.Questions
{
    public abstract class ChoiceQuestion : Question
    {
        protected readonly IEnumerable<Answer> PossibleAnswers;

        protected ChoiceQuestion(string stepMessage, IEnumerable<Answer> possibleAnswers)
            : base(stepMessage)
        {
            PossibleAnswers = possibleAnswers;
        }

        public IEnumerable<Answer> GetPossibleChoices()
        {
            return PossibleAnswers;
        }

        public override string ToString()
        {
            var display = new StringBuilder(base.ToString());
            foreach (var possibleAnswer in PossibleAnswers)
            {
                display.Append(ChoiceIcon()).AppendLine(possibleAnswer.ToString());
            }
            return display.ToString();
        }

        protected abstract string ChoiceIcon();
    }
}
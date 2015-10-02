using System;
using System.Collections.Generic;
using System.Linq;
using InteractionsExercise.Steps.Answers;

namespace InteractionsExercise.Steps.Questions
{
    public class MultipleChoiceQuestion : ChoiceQuestion
    {
        private readonly ISet<Answer> _chosenAnswers = new HashSet<Answer>();

        public MultipleChoiceQuestion(string stepMessage, IEnumerable<Answer> possibleAnswers)
            : base(stepMessage, possibleAnswers)
        {
        }

        public override void SetAnswer(Answer answer)
        {
            if (PossibleAnswers.Contains(answer)) _chosenAnswers.Add(answer);
            throw new ArgumentException("Invalid choice");
        }

        public override bool CanContinue()
        {
            return _chosenAnswers.Any();
        }


        protected override string ChoiceIcon()
        {
            return "[ ]";
        }
    }
}
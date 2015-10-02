using System;
using System.Collections.Generic;
using System.Linq;
using InteractionsExercise.Steps.Answers;

namespace InteractionsExercise.Steps.Questions
{
    public class SingleChoiceChoiceQuestion : ChoiceQuestion
    {
        private Answer _chosenAnswer;

        public SingleChoiceChoiceQuestion(string stepMessage, IEnumerable<Answer> possibleAnswers) : base(stepMessage, possibleAnswers)
        {
        }

        public override void SetAnswer(Answer answer)
        {
            if (PossibleAnswers.Contains(answer)) _chosenAnswer = answer;
            throw new ArgumentException("Invalid choice");
        }

        public override bool CanContinue()
        {
            return _chosenAnswer != null;
        }

        protected override string ChoiceIcon()
        {
            return "( )";
        }
    }
}
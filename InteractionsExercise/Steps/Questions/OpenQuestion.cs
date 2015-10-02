using InteractionsExercise.Steps.Answers;

namespace InteractionsExercise.Steps.Questions
{
    public class OpenQuestion : Question
    {
        private Answer _answer;
        public OpenQuestion(string stepMessage) : base(stepMessage)
        {
        }

        public override void SetAnswer(Answer answer)
        {
            _answer = answer;
        }

        public override bool CanContinue()
        {
            return _answer != null;
        }
    }
}
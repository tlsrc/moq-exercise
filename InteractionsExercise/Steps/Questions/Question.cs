using InteractionsExercise.Steps.Answers;

namespace InteractionsExercise.Steps.Questions
{
    public abstract class Question : QuestionnaireStep
    {
        protected Question(string stepMessage) : base(stepMessage)
        {
        }

        public abstract void SetAnswer(Answer answer);
    }
}
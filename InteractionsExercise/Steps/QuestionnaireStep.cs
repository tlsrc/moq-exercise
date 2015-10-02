
namespace InteractionsExercise.Steps
{
    public abstract class QuestionnaireStep
    {
        private readonly string _stepMessage;

        protected QuestionnaireStep(string stepMessage)
        {
            _stepMessage = stepMessage;
        }

        public abstract bool CanContinue();

        public override string ToString()
        {
            return _stepMessage;
        }
    }
}
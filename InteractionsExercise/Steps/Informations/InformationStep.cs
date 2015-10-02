namespace InteractionsExercise.Steps.Informations
{
    public class InformationStep : QuestionnaireStep
    {
        public InformationStep(string stepMessage) : base(stepMessage)
        {
        }

        public override bool CanContinue()
        {
            return true;
        }
    }
}

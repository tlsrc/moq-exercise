
namespace InteractionsExercise.Steps.Informations
{
    public class FinalStep : InformationStep
    {
        public FinalStep() : base("Merci d'avoir pris le temps de répondre à ce questionnaire !")
        {
        }

        public override bool CanContinue()
        {
            return true;
        }
    }
}

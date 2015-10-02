namespace InteractionsExercise.Steps.Informations
{
    public class FirstStep : InformationStep
    {
        public FirstStep() : base("Nous allons vous poser plusieurs questions d'assurabilité")
        {
        }

        public override bool CanContinue()
        {
            return true;
        }
    }
}
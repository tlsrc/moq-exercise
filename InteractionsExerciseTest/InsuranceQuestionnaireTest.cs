using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InteractionsExerciseTest
{
    [TestClass]
    public class InsuranceQuestionnaireTest
    {
        [TestMethod]
        public void BeginStep_WithoutPreviousStep_GivesFirstStep()
        {
        }

        [TestMethod]
        public void BeginStep_WithPreviousTStep_GivesNextStep()
        {

        }

        [TestMethod]
        public void CompleteStep_WithIncompleteStep_RefusesToFinishStep()
        {

        }

        [TestMethod]
        public void CompleteStep_WithCompleteStep_FinishesStep()
        {

        }

        [TestMethod]
        public void CompleteStep_WithCompleteAndFinalStep_FinishesStepAndQuestionnaire()
        {

        }
    }
}

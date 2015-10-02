using System.Collections.Generic;

namespace InteractionsExercise.Steps
{
    public interface IStepProvider
    {
        QuestionnaireStep GetFirstStep();
        QuestionnaireStep GetNextStep(IEnumerable<QuestionnaireStep> previousSteps);
        bool HasMoreSteps(IEnumerable<QuestionnaireStep> previousSteps);
        void FinishQuestionnaire(IEnumerable<QuestionnaireStep> previousSteps);
    }
}
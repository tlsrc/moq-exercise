using System.Collections.Generic;
using System.Linq;
using InteractionsExercise.Steps;
using InteractionsExercise.Steps.Result;

namespace InteractionsExercise
{
    public class InsuranceQuestionnaire
    {
        private readonly IStepProvider _stepProvider;
        private readonly IList<QuestionnaireStep> _previousSteps;

        public InsuranceQuestionnaire(IStepProvider stepProvider) : this(new List<QuestionnaireStep>(), stepProvider)
        {
        }

        public InsuranceQuestionnaire(IList<QuestionnaireStep> previousSteps, IStepProvider stepProvider)
        {
            _previousSteps = previousSteps;
            _stepProvider = stepProvider;
        }

        public QuestionnaireStep BeginStep()
        {
            if (_previousSteps.Any())
            {
                return _stepProvider.GetNextStep(_previousSteps);
            }
            
            return _stepProvider.GetFirstStep();
        }

        public StepCompletionResult CompleteStep(QuestionnaireStep doneStep)
        {
            if (!doneStep.CanContinue())
            {
                return new IncompleteStep();    
            }

            _previousSteps.Add(doneStep);

            if (_stepProvider.HasMoreSteps(_previousSteps))
            {
                return new StepCompletedSuccesfully();
            }
            _stepProvider.FinishQuestionnaire(_previousSteps);
            return new QuestionnaireCompletedSuccesfully();
        }

    }
}
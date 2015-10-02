namespace InteractionsExercise.Steps.Answers
{
    public abstract class Answer
    {
        private readonly string _answerText;

        protected Answer(string answerText)
        {
            _answerText = answerText;
        }

        public override string ToString()
        {
            return _answerText;
        }
    }
}

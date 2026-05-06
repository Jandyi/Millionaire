namespace Millionaire
{
    //a class derived from QUESTIONBASE that contains: question text,level, the true and wrong answer
    public class QUESTION:QUESTIONBASE
    {
        public string TrueAnswer = "";
        public string[] WrongAnswer = new string[6];
        // a constructor that recieves the parameters and passes the parameters ( level, question) to the base constructor
        public QUESTION(int level,string question,string[] wrongAnswer,string trueanswer) : base (level, question)
        {
            TrueAnswer = trueanswer;
            WrongAnswer = wrongAnswer;
        }
        //overrides the base method ISCORRECT returning TRUE if the answer is correct
        public override bool ISCORRECT(string answer)
        {
            return TrueAnswer.ToLower()==answer.ToLower();
        }
    }
}

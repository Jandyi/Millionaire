namespace Millionaire
{
    public abstract class QUESTIONBASE
    { //an abstract class, Question base that contains the question and the level
        public int Level = 0;
        public string Question = "";
        public  QUESTIONBASE(int level, string question)
        {//A constructor that recieves the question and level
            Level = level;
            Question = question;
        }
        public abstract bool ISCORRECT(string answer);
    }// an abstract method that returns a boolean for checking the right answer

}
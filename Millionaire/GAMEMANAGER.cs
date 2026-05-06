
using System.Collections.Immutable;

namespace Millionaire
{
    internal class GAMEMANAGER
    {
        public string[,] QuestionArray=new string[15,5]; //two deminsional array to store the questions
        public Random Random = new Random();
     public void  LOADQUESTIONS(string PATH) //a function that loads the questions from the file
     {
        StreamReader FileQuestion = new StreamReader(PATH);
        int Rows = -1;
        while (!FileQuestion.EndOfStream) 
        {
            string strLine=FileQuestion.ReadLine();
            if (strLine.StartsWith("#")) //new level starts with #
            {
                Rows += 1;
                for(int column = 0;column<5; column++)
                {
                    QuestionArray[Rows, column] =FileQuestion.ReadLine() ; 
                }   
            }
        }
      }
    public string GETRANDOMQUESTION(int LEVEL) //a function that randomly chooses a question in the specfic level
        {
          return QuestionArray[LEVEL-1,  Random.Next(4)];
        }
    public string[] GETSHUFFLEDANSWERS(QUESTION Q) //a function that shuffles the correct answer with the wrong one
        { 
            int[] indexlist = new int[4];
            indexlist[0] = -1; //assigns -1 as the correct answer to the first element in the array
            int  Count = 1; //count starts from 1 because 0 holds the correct answer
            while (Count < 4) //fills the remaning slots with random unique wrong answers 
            {
              int index =  Random.Next(6);
              if (!indexlist.Contains(index)) 
                { indexlist[Count] = index;
                  Count++;
                }
            }
            int n = indexlist.Length; 
            while (n > 1) //shuffle to randomize index order
            {
                int k = Random.Next(n--);
                int temp = indexlist[n]; 
                indexlist[n] = indexlist[k];
                indexlist[k] = temp;
            }
            string[] mixedanswer = new string[5]; //intializes a string array holding answer text coressponding from the indexlist
            for (int i = 0; i < 4; i++)
            {
                if (indexlist[i] == -1)
                {
                    mixedanswer[4] = i.ToString(); //stores the index of the true answer at the last element of the array
                    mixedanswer[i] = Q.TrueAnswer; //assigns the true answer
                }
                else mixedanswer[i] = Q.WrongAnswer[indexlist[i]]; //assigns the wrong answers
            } 
            return mixedanswer;
        }
    }
}

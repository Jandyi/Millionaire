using System.Runtime.InteropServices;
using System.Security.Policy;

namespace Millionaire
{
    public partial class Form1 : Form
    {
        GAMEMANAGER gamemanager = new GAMEMANAGER();
        QUESTION question;
        int level = 0;
        int TrueIndex = -1;
        bool fifty = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void setquestion(int level)
        {
            Random random = new Random();
            string strquestion = gamemanager.QuestionArray[level, random.Next(5)];
            string[] tempsplit = strquestion.Split(';'); //splits the question and the answers 
            string[] wrong = new string[6];

            for (int i = 2; i < tempsplit.Length; i++) //copies the wrong answer from tempsplit to wrong array
            {
                wrong[i - 2] = tempsplit[i];
            }
            question = new QUESTION(level, tempsplit[0], wrong, tempsplit[1]);

            string[] shuffled = gamemanager.GETSHUFFLEDANSWERS(question);

            labellevel.Text = $"Level : {level + 1}";
            listlevel.SelectedIndex = 14 - level; //assigns listlevel selected index to the current level
            labelmoney.Text =  (level > 0 ? listlevel.Items[listlevel.SelectedIndex + 1].ToString() : "$0"); // current credit;

            labelcurrent.Text = listlevel.SelectedItem.ToString();
            if (fifty) //flags to Re-enable all answer buttons for the new level if fiftyfifty is activated
            {
                AnswerA.Enabled = true;
                AnswerB.Enabled = true;
                AnswerC.Enabled = true;
                AnswerD.Enabled = true;
                fifty = false;
            }
            LabelQuestion.Text = question.Question;
            AnswerA.Text = shuffled[0];
            AnswerB.Text = shuffled[1];
            AnswerC.Text = shuffled[2];
            AnswerD.Text = shuffled[3];
            TrueIndex = int.Parse(shuffled[4]); //index 4 stores the correct answer position
        }
        void TestAnswer(Button Answer)
        {
            if (MessageBox.Show($"Is ''{Answer.Text}'' your final answer?", "Final Answer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (question.ISCORRECT(Answer.Text))
                {
                    MessageBox.Show($"Correct! You Won {listlevel.SelectedItem}");
                    if (level < 14) //checks for the final level
                    {
                        level++;
                        setquestion(level);
                     }
                    else
                    {
                        labelcurrent.Text = "$1.000.000";
                        MessageBox.Show("You reached the top prize!");
                        EnableGame(false);
                    }
                }
                else
                {
                    string earned = (level > 4 && level < 9) ? "$1000" : (level > 9) ? "$32000" : "$0";
                    EnableGame(false);
                    MessageBox.Show($"Wrong answer! Game over.\nThe answer is : {question.TrueAnswer}\nYou earned {earned}");
                }
            }
        }
        private void AnswerA_Click(object sender, EventArgs e)
        {

            TestAnswer(AnswerA);
        }

        private void AnswerB_Click(object sender, EventArgs e)
        {
            TestAnswer(AnswerB);
        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            TestAnswer(AnswerC);
        }

        private void AnswerD_Click(object sender, EventArgs e)
        {
            TestAnswer(AnswerD);
        }
        void EnableGame(bool state) //method to enable or disable buttons
        {
            LabelQuestion.Enabled = state;
            AnswerA.Enabled = state;
            AnswerB.Enabled = state;
            AnswerC.Enabled = state;
            AnswerD.Enabled = state;
            fiftyfifty.Enabled = state;
            switchquestion.Enabled = state;
            withdrawbutton.Enabled = state;
            gamestart.Enabled = !state;
        }
        private void switchquestion_Click(object sender, EventArgs e)
        {
            switchquestion.Enabled = false;
            string currentquestion = LabelQuestion.Text;
            //Keep getting questions until we find a different one
            while (currentquestion == LabelQuestion.Text)
            {
                setquestion(level);
            }
        }
        private void fiftyfifty_Click(object sender, EventArgs e)
        {
            fifty = true;
            fiftyfifty.Enabled = false;
            int selectedWrongIndex = -1;
            Random random = new Random();
            //loop until the selected wrong index not equal the true index
            while (selectedWrongIndex == -1 || selectedWrongIndex == TrueIndex)
            {
                selectedWrongIndex = random.Next(0, 4);
            }
            //keep correct answer plus one random wrong answer enabled
            AnswerA.Enabled = (0 == selectedWrongIndex || 0 == TrueIndex);
            AnswerB.Enabled = (1 == selectedWrongIndex || 1 == TrueIndex);
            AnswerC.Enabled = (2 == selectedWrongIndex || 2 == TrueIndex);
            AnswerD.Enabled = (3 == selectedWrongIndex || 3 == TrueIndex);
        }

        private void withdrawbutton_Click(object sender, EventArgs e)
        { //withdraw button clicked and shows a messagebox, finishing the game
            if (MessageBox.Show($"You will withdraw with {labelmoney.Text}.\n Is this your final dicision?", "Withdraw - Final Dicision", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show($"You decided to walk away with {labelmoney.Text}. Thanks for playing!");
                EnableGame(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamemanager.LOADQUESTIONS("questions.txt"); //loads the questions from the file
            EnableGame(false);
        }

        private void gamestart_Click(object sender, EventArgs e)
        {
            level = 0;
            setquestion(level);
            EnableGame(true);
        }
    }
}

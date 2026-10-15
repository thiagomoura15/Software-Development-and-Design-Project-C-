using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeakPerformanceQuiz
{
    public partial class frm_question3 : Form
    {
        public frm_question3()
        {
            InitializeComponent();

            //stores the public interger 'playerScore' as a local variable named 'score'
            //, so that it can be converted to a string to be displayed on the label 
            int score = frm_question1.instance.playerScore;
            lbl_score2.Text = score.ToString();
            
            //starts the timer 
            timer3.Start();
        }

        private void btn_returnmm3_Click(object sender, EventArgs e)
        {
            //opens start screen and closes this screen
            new frm_startscreen().Show();
            this.Hide();
        }

        private void btn_nextquestion3_Click(object sender, EventArgs e)
        {
            //once button is clicked
            //checks if there is an answer inserted 
            if (txt_answer3.Text == "")
            {
                //if not a message box will pop up telling the user to insert an answer
                MessageBox.Show("Please Insert an Answer!");
            }
            //checks if the correct answer was inserted
            else if (txt_answer3.Text == "5")
            {
                //if the correct answer is inserted a message box will 
                //pop up telling the user that the answer is correct 
                MessageBox.Show("Well done! That is the Correct Answer.");

                //the timer will also stop 
                timer3.Stop();

                //adds 10 to the score 
                frm_question1.instance.playerScore = frm_question1.instance.playerScore + 10;

                //then the next question will open and this question will close
                //, carring over the time that was left once the timer stopped
                new frm_question4().Show();
                this.Hide();
            }
            //checks if the incorrect answer was inserted 
            else
            {
                //if the incorrect answer is inserted then a message box will
                //pop up telling the user that the answer is incorrect
                MessageBox.Show("Unlucky! This is the Incorrect Answer. The Answer was 5.");

                //the timer will stop
                timer3.Stop();

                //then the next question will open and this question will close
                new frm_question4().Show();
                this.Hide();
            }
        }

        private void pic_rules4_Click(object sender, EventArgs e)
        {
            //once clicked opens rules screen 
            new frm_rulescreen().Show();    
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //this takes away one second during the time the form is opened 
            frm_question1.instance.timeleft--;

            //puts the stored integer timeleft (what ever time was left
            //, when the time stopped on the last screen)
            //then will display the time into the format of mm;ss
            TimeSpan time = TimeSpan.FromSeconds(frm_question1.instance.timeleft);
            this.lbl_timer2.Text = time.ToString("mm\\:ss");

            //checks if the timer reaches 0
            if (frm_question1.instance.timeleft == 0)
            {
                //message box will pop up telling that they run out of time and to try again
                MessageBox.Show("Unlucky, your time has run out! Try Again");

                //opens the start screen and closes the screen your on
                new frm_startscreen().Show();
                this.Hide();
            }
        }
    }
}


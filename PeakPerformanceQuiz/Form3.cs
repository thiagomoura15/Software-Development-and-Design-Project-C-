using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeakPerformanceQuiz
{
    public partial class frm_question1 : Form
    { 
        //storing time left and player score as a
        //public integer to be used on all forms
        public int timeleft = 300;
        public int playerScore = 0;
        public static frm_question1 instance;
        
        public frm_question1()
        {
            InitializeComponent();
            instance = this;

            //displays the players score in a
            //string format in the label 'lbl_score'
            lbl_score.Text = playerScore.ToString();

            //this starts the timer
            timer1.Start();
        }

        private void pic_rules1_Click(object sender, EventArgs e)
        {
            //once clicked opens the rules screen
            new frm_rulescreen().Show();
        }

        private void btn_nextquestion_Click(object sender, EventArgs e)
        {
            //once button is clicked
            //checks if there is an answer inserted 
            if (txt_answer1.Text == "")
            {
                //if not a message box will pop up telling the user to insert an answer
                MessageBox.Show("Please Insert an Answer!");      
            }
            //checks if the correct answer was inserted
            else if (txt_answer1.Text.ToLower() == "golf")
            {
                //if the correct answer is inserted a message box will 
                //pop up telling the user that the answer is correct 
                MessageBox.Show("Well done! That is the Correct Answer. ");
                
                //the timer will also stop 
                timer1.Stop();

                //adds 10 to the score 
                playerScore = playerScore + 10;

                //then the next question will open and this question will close
                new frm_question2().Show();
                this.Hide();
            }
            //checks if the incorrect answer was inserted 
            else   
            {
                //if the incorrect answer is inserted then a message box will
                //pop up telling the user that the answer is incorrect
                MessageBox.Show("Unlucky! This is the Incorrect Answer. The Answer was golf.");

                //the timer will stop
                timer1.Stop();

                //then the next question will open and this question will close
                new frm_question2().Show();
                this.Hide();
            }
        }

        private void btn_returnmm_Click(object sender, EventArgs e)
        {
            //once button is clicked the start screen will open up and this screen will close 
            new frm_startscreen().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this takes away one second during the time the form is opened 
            timeleft--;

            //puts the stored interger timeleft (300) into seconds 
            //then will display the time into the format of mm;ss 
            TimeSpan time = TimeSpan.FromSeconds(timeleft);
            this.lbl_timer.Text = time.ToString("mm\\:ss");

            //checks if the timer reaches 0
            if (timeleft == 0)
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

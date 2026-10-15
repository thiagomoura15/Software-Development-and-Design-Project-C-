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
    public partial class frm_question5 : Form
    {
        public frm_question5()
        {
            InitializeComponent();

            //stores the public interger 'playerScore' as a local variable named 'score'
            //, so that it can be converted to a string to be displayed on the label 
            int score = frm_question1.instance.playerScore;
            lbl_score4.Text = score.ToString();

            //starts the timer
            timer5.Start();
        }

        private void btn_returnmm5_Click(object sender, EventArgs e)
        {
            //when clicked it will open the start screen and close this screen
            new frm_startscreen().Show();
            this.Hide();    
        }

        private void btn_resultscreen_Click(object sender, EventArgs e)
        {
            //open button is clicked checks if the ratio button 2 was selected 
            if (rbtn_option3.Checked == true)
            {
                // if it was selected then a message box will pop up saying
                //that the user got the answer correct 
                MessageBox.Show("Well done! This is the Correct Answer.");

                //adds 10 to the players score 
                frm_question1.instance.playerScore = frm_question1.instance.playerScore + 10;

                //stops the timer 
                timer5.Stop();

                //the next question will open and this screen will close 
                new frm_resultscreen().Show();
                this.Hide();
            }
            //checks if anything but the radio button 2 is selected
            else
            {
                //if any other radio button was selected it, a message box will pop up saying
                //that the user has selected the incorrect answer
                MessageBox.Show("Unlucky! This is the Incorrect Answer. The Answer was Swimming.");

                //stops the timer
                timer5.Stop();

                //opens the next question and closes this screen  
                new frm_resultscreen().Show();
                this.Hide();
            }
        }

        private void pic_rules5_Click(object sender, EventArgs e)
        {
            //when clicked opens the rules screen 
            new frm_rulescreen().Show();    
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //this takes away one second during the time the form is opened
            frm_question1.instance.timeleft--;

            //puts the stored integer timeleft (what ever time was left
            //, when the time stopped on the last screen)
            //then will display the time into the format of mm;ss
            TimeSpan time = TimeSpan.FromSeconds(frm_question1.instance.timeleft);
            this.lbl_timer4.Text = time.ToString("mm\\:ss");

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

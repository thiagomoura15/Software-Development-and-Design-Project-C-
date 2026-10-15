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
    public partial class frm_resultscreen : Form
    {
        public frm_resultscreen()
        {
            InitializeComponent();

            //displays the user 'username' by using the forename and surname they inserted when starting the quiz 
            lbl_username.Text = frm_startscreen.instance.forename + " " + frm_startscreen.instance.surname;

            //displays the users final score
            int Fscore = frm_question1.instance.playerScore;
            lbl_finalscore.Text = Fscore.ToString();
        }

        private void btn_returnmm6_Click(object sender, EventArgs e)
        {
            //when clicked opens the start screen and closes this screen
            new frm_startscreen().Show();
            this.Hide();
        }

        private void pic_rules8_Click(object sender, EventArgs e)
        {
            //when clicked opens the rules screen
            new frm_rulescreen().Show();    
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            //closes the whole application 
            Application.Exit();
        }


    }
}

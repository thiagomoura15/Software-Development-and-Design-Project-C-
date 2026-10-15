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
    public partial class frm_startscreen : Form
    {
        //stores forename, surname as a string
        //made all of them public to be able to access them from different forms
        public string forename;
        public string surname;
        public static frm_startscreen instance;


        public frm_startscreen()
        {
            InitializeComponent();
            instance = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Opens the rules screen once the button is clicked 
            new frm_rulescreen().Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //once button is clicked 
            //checks if the forename button is empty 
            if (txt_forename.Text == "")
            {
                //if it is empty a message box will pop up telling the user to insert a forename 
                MessageBox.Show("Must Insert a Forename");
                txt_forename.Focus();
            }
            //checks if the surename button is empty 
            else if (txt_surname.Text == "")
            {
                //if it is empty a message box will pop up telling the user to insert a surname 
                MessageBox.Show("Must Insert a Surname");
                txt_surname.Focus();
            }
            //if both forename and surname are filled in
            else
            {
                //stores the forename and surname to string
                this.forename = txt_forename.Text;
                this.surname = txt_surname.Text;

                //stores the forename and surname to string
                txt_forename.Text = forename;
                txt_surname.Text = surname;


                //then opens up the first question 
                new frm_question1().Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes the application once the button is clicked 
            Application.Exit();
        }
    }
}

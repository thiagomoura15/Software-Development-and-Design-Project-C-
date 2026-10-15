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
    public partial class frm_rulescreen : Form
    {
        public frm_rulescreen()
        {
            InitializeComponent();
        }
        private void lbl_close_Click(object sender, EventArgs e)
        {
            //once clicked the rules screen will close this screen
            this.Hide();
        }
    }
}

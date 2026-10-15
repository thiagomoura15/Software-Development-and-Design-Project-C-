namespace PeakPerformanceQuiz
{
    partial class frm_question1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_question1title = new System.Windows.Forms.Label();
            this.lbl_question1 = new System.Windows.Forms.Label();
            this.lbl_insertanswer1 = new System.Windows.Forms.Label();
            this.txt_answer1 = new System.Windows.Forms.TextBox();
            this.btn_nextquestion1 = new System.Windows.Forms.Button();
            this.btn_returnmm1 = new System.Windows.Forms.Button();
            this.pic_rules1 = new System.Windows.Forms.PictureBox();
            this.pic_golf = new System.Windows.Forms.PictureBox();
            this.lbl_timeleft = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_sc = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_golf)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_question1title
            // 
            this.lbl_question1title.AutoSize = true;
            this.lbl_question1title.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question1title.Location = new System.Drawing.Point(370, 12);
            this.lbl_question1title.Name = "lbl_question1title";
            this.lbl_question1title.Size = new System.Drawing.Size(353, 84);
            this.lbl_question1title.TabIndex = 0;
            this.lbl_question1title.Text = "Question 1";

            // 
            // lbl_question1
            // 
            this.lbl_question1.AutoSize = true;
            this.lbl_question1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question1.Location = new System.Drawing.Point(268, 116);
            this.lbl_question1.Name = "lbl_question1";
            this.lbl_question1.Size = new System.Drawing.Size(569, 28);
            this.lbl_question1.TabIndex = 1;
            this.lbl_question1.Text = "1 ) What is the name of the Sport shown in the image below.";
            // 
            // lbl_insertanswer1
            // 
            this.lbl_insertanswer1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertanswer1.Location = new System.Drawing.Point(297, 567);
            this.lbl_insertanswer1.Name = "lbl_insertanswer1";
            this.lbl_insertanswer1.Size = new System.Drawing.Size(222, 23);
            this.lbl_insertanswer1.TabIndex = 8;
            this.lbl_insertanswer1.Text = "Insert Answer Here :";
            // 
            // txt_answer1
            // 
            this.txt_answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer1.Location = new System.Drawing.Point(507, 563);
            this.txt_answer1.Multiline = true;
            this.txt_answer1.Name = "txt_answer1";
            this.txt_answer1.Size = new System.Drawing.Size(305, 35);
            this.txt_answer1.TabIndex = 7;
            // 
            // btn_nextquestion1
            // 
            this.btn_nextquestion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_nextquestion1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextquestion1.Location = new System.Drawing.Point(876, 645);
            this.btn_nextquestion1.Name = "btn_nextquestion1";
            this.btn_nextquestion1.Size = new System.Drawing.Size(177, 57);
            this.btn_nextquestion1.TabIndex = 5;
            this.btn_nextquestion1.Text = "Next Question ";
            this.btn_nextquestion1.UseVisualStyleBackColor = false;
            this.btn_nextquestion1.Click += new System.EventHandler(this.btn_nextquestion_Click);
            // 
            // btn_returnmm1
            // 
            this.btn_returnmm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_returnmm1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnmm1.Location = new System.Drawing.Point(12, 645);
            this.btn_returnmm1.Name = "btn_returnmm1";
            this.btn_returnmm1.Size = new System.Drawing.Size(242, 57);
            this.btn_returnmm1.TabIndex = 1;
            this.btn_returnmm1.Text = "Return to main menu";
            this.btn_returnmm1.UseVisualStyleBackColor = false;
            this.btn_returnmm1.Click += new System.EventHandler(this.btn_returnmm_Click);
            // 
            // pic_rules1
            // 
            this.pic_rules1.Image = global::PeakPerformanceQuiz.Properties.Resources.rules;
            this.pic_rules1.Location = new System.Drawing.Point(999, 12);
            this.pic_rules1.Name = "pic_rules1";
            this.pic_rules1.Size = new System.Drawing.Size(54, 58);
            this.pic_rules1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rules1.TabIndex = 0;
            this.pic_rules1.TabStop = false;
            this.pic_rules1.Click += new System.EventHandler(this.pic_rules1_Click);
            // 
            // pic_golf
            // 
            this.pic_golf.Image = global::PeakPerformanceQuiz.Properties.Resources.Golf;
            this.pic_golf.Location = new System.Drawing.Point(224, 161);
            this.pic_golf.Name = "pic_golf";
            this.pic_golf.Size = new System.Drawing.Size(665, 368);
            this.pic_golf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_golf.TabIndex = 2;
            this.pic_golf.TabStop = false;

            // 
            // lbl_timeleft
            // 
            this.lbl_timeleft.AutoSize = true;
            this.lbl_timeleft.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeleft.Location = new System.Drawing.Point(6, 9);
            this.lbl_timeleft.Name = "lbl_timeleft";
            this.lbl_timeleft.Size = new System.Drawing.Size(122, 31);
            this.lbl_timeleft.TabIndex = 9;
            this.lbl_timeleft.Text = "Time Left";
            // 
            // lbl_timer
            // 
            this.lbl_timer.BackColor = System.Drawing.Color.White;
            this.lbl_timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_timer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(134, 10);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(120, 30);
            this.lbl_timer.TabIndex = 10;
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_sc
            // 
            this.lbl_sc.AutoSize = true;
            this.lbl_sc.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sc.Location = new System.Drawing.Point(41, 55);
            this.lbl_sc.Name = "lbl_sc";
            this.lbl_sc.Size = new System.Drawing.Size(78, 31);
            this.lbl_sc.TabIndex = 11;
            this.lbl_sc.Text = "Score";
            // 
            // lbl_score
            // 
            this.lbl_score.BackColor = System.Drawing.Color.White;
            this.lbl_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_score.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(134, 56);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(79, 30);
            this.lbl_score.TabIndex = 12;
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 714);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_sc);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_timeleft);
            this.Controls.Add(this.pic_rules1);
            this.Controls.Add(this.btn_returnmm1);
            this.Controls.Add(this.btn_nextquestion1);
            this.Controls.Add(this.txt_answer1);
            this.Controls.Add(this.lbl_insertanswer1);
            this.Controls.Add(this.pic_golf);
            this.Controls.Add(this.lbl_question1);
            this.Controls.Add(this.lbl_question1title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_question1";
            this.Text = "frm_question1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_golf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question1title;
        private System.Windows.Forms.Label lbl_question1;
        private System.Windows.Forms.PictureBox pic_golf;
        private System.Windows.Forms.Label lbl_insertanswer1;
        private System.Windows.Forms.TextBox txt_answer1;
        private System.Windows.Forms.Button btn_nextquestion1;
        private System.Windows.Forms.Button btn_returnmm1;
        private System.Windows.Forms.PictureBox pic_rules1;
        private System.Windows.Forms.Label lbl_timeleft;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sc;
        private System.Windows.Forms.Label lbl_score;
    }
}
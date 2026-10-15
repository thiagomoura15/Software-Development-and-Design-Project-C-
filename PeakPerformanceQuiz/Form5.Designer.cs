namespace PeakPerformanceQuiz
{
    partial class frm_question3
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
            this.lbl_question3title = new System.Windows.Forms.Label();
            this.lbl_question3 = new System.Windows.Forms.Label();
            this.lbl_insertanswer3 = new System.Windows.Forms.Label();
            this.txt_answer3 = new System.Windows.Forms.TextBox();
            this.btn_returnmm3 = new System.Windows.Forms.Button();
            this.btn_nextquestion3 = new System.Windows.Forms.Button();
            this.pic_basketball = new System.Windows.Forms.PictureBox();
            this.pic_rules3 = new System.Windows.Forms.PictureBox();
            this.lbl_timeleft3 = new System.Windows.Forms.Label();
            this.lbl_timer2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score2 = new System.Windows.Forms.Label();
            this.lbl_sc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_basketball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_question3title
            // 
            this.lbl_question3title.AutoSize = true;
            this.lbl_question3title.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question3title.Location = new System.Drawing.Point(369, 12);
            this.lbl_question3title.Name = "lbl_question3title";
            this.lbl_question3title.Size = new System.Drawing.Size(353, 84);
            this.lbl_question3title.TabIndex = 2;
            this.lbl_question3title.Text = "Question 3";
            // 
            // lbl_question3
            // 
            this.lbl_question3.AutoSize = true;
            this.lbl_question3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question3.Location = new System.Drawing.Point(246, 114);
            this.lbl_question3.Name = "lbl_question3";
            this.lbl_question3.Size = new System.Drawing.Size(570, 28);
            this.lbl_question3.TabIndex = 4;
            this.lbl_question3.Text = "3 ) In Basketball, how many players are there on each team?";
            // 
            // lbl_insertanswer3
            // 
            this.lbl_insertanswer3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertanswer3.Location = new System.Drawing.Point(330, 591);
            this.lbl_insertanswer3.Name = "lbl_insertanswer3";
            this.lbl_insertanswer3.Size = new System.Drawing.Size(208, 23);
            this.lbl_insertanswer3.TabIndex = 10;
            this.lbl_insertanswer3.Text = "Insert Answer Here :";
            // 
            // txt_answer3
            // 
            this.txt_answer3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer3.Location = new System.Drawing.Point(532, 585);
            this.txt_answer3.Multiline = true;
            this.txt_answer3.Name = "txt_answer3";
            this.txt_answer3.Size = new System.Drawing.Size(305, 35);
            this.txt_answer3.TabIndex = 11;
            // 
            // btn_returnmm3
            // 
            this.btn_returnmm3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_returnmm3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnmm3.Location = new System.Drawing.Point(12, 673);
            this.btn_returnmm3.Name = "btn_returnmm3";
            this.btn_returnmm3.Size = new System.Drawing.Size(226, 57);
            this.btn_returnmm3.TabIndex = 13;
            this.btn_returnmm3.Text = "Return to main menu";
            this.btn_returnmm3.UseVisualStyleBackColor = false;
            this.btn_returnmm3.Click += new System.EventHandler(this.btn_returnmm3_Click);
            // 
            // btn_nextquestion3
            // 
            this.btn_nextquestion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_nextquestion3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextquestion3.Location = new System.Drawing.Point(893, 673);
            this.btn_nextquestion3.Name = "btn_nextquestion3";
            this.btn_nextquestion3.Size = new System.Drawing.Size(177, 57);
            this.btn_nextquestion3.TabIndex = 15;
            this.btn_nextquestion3.Text = "Next Question ";
            this.btn_nextquestion3.UseVisualStyleBackColor = false;
            this.btn_nextquestion3.Click += new System.EventHandler(this.btn_nextquestion3_Click);
            // 
            // pic_basketball
            // 
            this.pic_basketball.Image = global::PeakPerformanceQuiz.Properties.Resources.Baskestball;
            this.pic_basketball.Location = new System.Drawing.Point(205, 157);
            this.pic_basketball.Name = "pic_basketball";
            this.pic_basketball.Size = new System.Drawing.Size(688, 396);
            this.pic_basketball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_basketball.TabIndex = 6;
            this.pic_basketball.TabStop = false;
            // 
            // pic_rules3
            // 
            this.pic_rules3.Image = global::PeakPerformanceQuiz.Properties.Resources.rules;
            this.pic_rules3.Location = new System.Drawing.Point(1016, 12);
            this.pic_rules3.Name = "pic_rules3";
            this.pic_rules3.Size = new System.Drawing.Size(54, 58);
            this.pic_rules3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rules3.TabIndex = 5;
            this.pic_rules3.TabStop = false;
            this.pic_rules3.Click += new System.EventHandler(this.pic_rules4_Click);
            // 
            // lbl_timeleft3
            // 
            this.lbl_timeleft3.AutoSize = true;
            this.lbl_timeleft3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeleft3.Location = new System.Drawing.Point(12, 12);
            this.lbl_timeleft3.Name = "lbl_timeleft3";
            this.lbl_timeleft3.Size = new System.Drawing.Size(122, 31);
            this.lbl_timeleft3.TabIndex = 16;
            this.lbl_timeleft3.Text = "Time Left";
            // 
            // lbl_timer2
            // 
            this.lbl_timer2.BackColor = System.Drawing.Color.GhostWhite;
            this.lbl_timer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_timer2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer2.Location = new System.Drawing.Point(140, 12);
            this.lbl_timer2.Name = "lbl_timer2";
            this.lbl_timer2.Size = new System.Drawing.Size(120, 30);
            this.lbl_timer2.TabIndex = 17;
            this.lbl_timer2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbl_score2
            // 
            this.lbl_score2.BackColor = System.Drawing.Color.White;
            this.lbl_score2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_score2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score2.Location = new System.Drawing.Point(140, 56);
            this.lbl_score2.Name = "lbl_score2";
            this.lbl_score2.Size = new System.Drawing.Size(79, 30);
            this.lbl_score2.TabIndex = 19;
            this.lbl_score2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sc
            // 
            this.lbl_sc.AutoSize = true;
            this.lbl_sc.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sc.Location = new System.Drawing.Point(47, 55);
            this.lbl_sc.Name = "lbl_sc";
            this.lbl_sc.Size = new System.Drawing.Size(78, 31);
            this.lbl_sc.TabIndex = 18;
            this.lbl_sc.Text = "Score";
            // 
            // frm_question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 742);
            this.Controls.Add(this.lbl_score2);
            this.Controls.Add(this.lbl_sc);
            this.Controls.Add(this.lbl_timer2);
            this.Controls.Add(this.lbl_timeleft3);
            this.Controls.Add(this.btn_nextquestion3);
            this.Controls.Add(this.btn_returnmm3);
            this.Controls.Add(this.txt_answer3);
            this.Controls.Add(this.lbl_insertanswer3);
            this.Controls.Add(this.pic_basketball);
            this.Controls.Add(this.pic_rules3);
            this.Controls.Add(this.lbl_question3);
            this.Controls.Add(this.lbl_question3title);
            this.Name = "frm_question3";
            this.Text = "frm_question3";
            ((System.ComponentModel.ISupportInitialize)(this.pic_basketball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question3title;
        private System.Windows.Forms.Label lbl_question3;
        private System.Windows.Forms.PictureBox pic_rules3;
        private System.Windows.Forms.PictureBox pic_basketball;
        private System.Windows.Forms.Label lbl_insertanswer3;
        private System.Windows.Forms.TextBox txt_answer3;
        private System.Windows.Forms.Button btn_returnmm3;
        private System.Windows.Forms.Button btn_nextquestion3;
        private System.Windows.Forms.Label lbl_timeleft3;
        private System.Windows.Forms.Label lbl_timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbl_score2;
        private System.Windows.Forms.Label lbl_sc;
    }
}
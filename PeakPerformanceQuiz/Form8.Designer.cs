namespace PeakPerformanceQuiz
{
    partial class frm_resultscreen
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
            this.lbl_results = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_welldone = new System.Windows.Forms.Label();
            this.gb_results = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_finalscore = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_fs = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pic_rules8 = new System.Windows.Forms.PictureBox();
            this.btn_returnmm6 = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.gb_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules8)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Font = new System.Drawing.Font("Copperplate Gothic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_results.Location = new System.Drawing.Point(276, 31);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(399, 89);
            this.lbl_results.TabIndex = 1;
            this.lbl_results.Text = "Results";
            this.lbl_results.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(193, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 2);
            this.panel1.TabIndex = 2;
            // 
            // lbl_welldone
            // 
            this.lbl_welldone.AutoSize = true;
            this.lbl_welldone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welldone.Location = new System.Drawing.Point(159, 161);
            this.lbl_welldone.Name = "lbl_welldone";
            this.lbl_welldone.Size = new System.Drawing.Size(621, 28);
            this.lbl_welldone.TabIndex = 3;
            this.lbl_welldone.Text = "Well Done! You have completed the Quiz. These are your results :";
            this.lbl_welldone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_results
            // 
            this.gb_results.Controls.Add(this.lbl_total);
            this.gb_results.Controls.Add(this.lbl_finalscore);
            this.gb_results.Controls.Add(this.lbl_username);
            this.gb_results.Controls.Add(this.lbl_fs);
            this.gb_results.Controls.Add(this.lbl_user);
            this.gb_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_results.Location = new System.Drawing.Point(205, 222);
            this.gb_results.Name = "gb_results";
            this.gb_results.Size = new System.Drawing.Size(552, 204);
            this.gb_results.TabIndex = 4;
            this.gb_results.TabStop = false;
            this.gb_results.Text = "Results";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(254, 116);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(44, 24);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "/ 50";
            // 
            // lbl_finalscore
            // 
            this.lbl_finalscore.BackColor = System.Drawing.Color.White;
            this.lbl_finalscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_finalscore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finalscore.Location = new System.Drawing.Point(180, 113);
            this.lbl_finalscore.Name = "lbl_finalscore";
            this.lbl_finalscore.Size = new System.Drawing.Size(66, 30);
            this.lbl_finalscore.TabIndex = 3;
            this.lbl_finalscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.White;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_username.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(180, 58);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(296, 30);
            this.lbl_username.TabIndex = 2;
            // 
            // lbl_fs
            // 
            this.lbl_fs.AutoSize = true;
            this.lbl_fs.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fs.Location = new System.Drawing.Point(54, 115);
            this.lbl_fs.Name = "lbl_fs";
            this.lbl_fs.Size = new System.Drawing.Size(112, 24);
            this.lbl_fs.TabIndex = 1;
            this.lbl_fs.Text = "Final Score :";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(66, 59);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(103, 24);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Username :";
            // 
            // pic_rules8
            // 
            this.pic_rules8.Image = global::PeakPerformanceQuiz.Properties.Resources.rules;
            this.pic_rules8.Location = new System.Drawing.Point(895, 12);
            this.pic_rules8.Name = "pic_rules8";
            this.pic_rules8.Size = new System.Drawing.Size(54, 58);
            this.pic_rules8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rules8.TabIndex = 12;
            this.pic_rules8.TabStop = false;
            this.pic_rules8.Click += new System.EventHandler(this.pic_rules8_Click);
            // 
            // btn_returnmm6
            // 
            this.btn_returnmm6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_returnmm6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnmm6.Location = new System.Drawing.Point(12, 503);
            this.btn_returnmm6.Name = "btn_returnmm6";
            this.btn_returnmm6.Size = new System.Drawing.Size(235, 57);
            this.btn_returnmm6.TabIndex = 32;
            this.btn_returnmm6.Text = "Return to main menu";
            this.btn_returnmm6.UseVisualStyleBackColor = false;
            this.btn_returnmm6.Click += new System.EventHandler(this.btn_returnmm6_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_quit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(785, 503);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(164, 57);
            this.btn_quit.TabIndex = 33;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // frm_resultscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 576);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_returnmm6);
            this.Controls.Add(this.pic_rules8);
            this.Controls.Add(this.gb_results);
            this.Controls.Add(this.lbl_welldone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_results);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_resultscreen";
            this.Text = "frm_resultscreen";
            this.gb_results.ResumeLayout(false);
            this.gb_results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_results;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_welldone;
        private System.Windows.Forms.GroupBox gb_results;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_fs;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_finalscore;
        private System.Windows.Forms.PictureBox pic_rules8;
        private System.Windows.Forms.Button btn_returnmm6;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lbl_total;
    }
}
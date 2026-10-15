namespace PeakPerformanceQuiz
{
    partial class frm_startscreen
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
            this.lbl_PP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_forename = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txt_forename = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.gb_startscreen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ast1 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.pic_rules = new System.Windows.Forms.PictureBox();
            this.gb_startscreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PP
            // 
            this.lbl_PP.AutoSize = true;
            this.lbl_PP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PP.Location = new System.Drawing.Point(158, 29);
            this.lbl_PP.Name = "lbl_PP";
            this.lbl_PP.Size = new System.Drawing.Size(673, 67);
            this.lbl_PP.TabIndex = 0;
            this.lbl_PP.Text = "Peak Performance";
            this.lbl_PP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(73, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 2);
            this.panel1.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(64, 134);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(848, 48);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Welcome to the Peak Performance quiz! When you\'re ready, enter your details where" +
    "  a \'*\' is displayed.\r\nTo access the rules select the button in the top right.";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // lbl_forename
            // 
            this.lbl_forename.AutoSize = true;
            this.lbl_forename.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forename.Location = new System.Drawing.Point(20, 62);
            this.lbl_forename.Name = "lbl_forename";
            this.lbl_forename.Size = new System.Drawing.Size(89, 24);
            this.lbl_forename.TabIndex = 3;
            this.lbl_forename.Text = "Forename";

            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(20, 106);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(80, 24);
            this.lbl_surname.TabIndex = 4;
            this.lbl_surname.Text = "Surname";
            // 
            // txt_forename
            // 
            this.txt_forename.Location = new System.Drawing.Point(138, 62);
            this.txt_forename.Multiline = true;
            this.txt_forename.Name = "txt_forename";
            this.txt_forename.Size = new System.Drawing.Size(243, 28);
            this.txt_forename.TabIndex = 5;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(138, 106);
            this.txt_surname.Multiline = true;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(243, 28);
            this.txt_surname.TabIndex = 6;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_start.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start.Location = new System.Drawing.Point(526, 421);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 59);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // gb_startscreen
            // 
            this.gb_startscreen.Controls.Add(this.label1);
            this.gb_startscreen.Controls.Add(this.lbl_ast1);
            this.gb_startscreen.Controls.Add(this.txt_forename);
            this.gb_startscreen.Controls.Add(this.txt_surname);
            this.gb_startscreen.Controls.Add(this.lbl_forename);
            this.gb_startscreen.Controls.Add(this.lbl_surname);
            this.gb_startscreen.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_startscreen.Location = new System.Drawing.Point(257, 217);
            this.gb_startscreen.Name = "gb_startscreen";
            this.gb_startscreen.Size = new System.Drawing.Size(456, 173);
            this.gb_startscreen.TabIndex = 8;
            this.gb_startscreen.TabStop = false;
            this.gb_startscreen.Text = "Player Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(387, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // lbl_ast1
            // 
            this.lbl_ast1.AutoSize = true;
            this.lbl_ast1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ast1.ForeColor = System.Drawing.Color.Red;
            this.lbl_ast1.Location = new System.Drawing.Point(387, 62);
            this.lbl_ast1.Name = "lbl_ast1";
            this.lbl_ast1.Size = new System.Drawing.Size(33, 39);
            this.lbl_ast1.TabIndex = 7;
            this.lbl_ast1.Text = "*";
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_quit.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(375, 421);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(112, 59);
            this.btn_quit.TabIndex = 10;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_rules
            // 
            this.pic_rules.Image = global::PeakPerformanceQuiz.Properties.Resources.rules;
            this.pic_rules.Location = new System.Drawing.Point(938, 29);
            this.pic_rules.Name = "pic_rules";
            this.pic_rules.Size = new System.Drawing.Size(54, 58);
            this.pic_rules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rules.TabIndex = 11;
            this.pic_rules.TabStop = false;
            this.pic_rules.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 516);
            this.Controls.Add(this.pic_rules);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_PP);
            this.Controls.Add(this.gb_startscreen);
            this.Name = "frm_startscreen";
            this.Text = "frm_startscreen";
            this.gb_startscreen.ResumeLayout(false);
            this.gb_startscreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_forename;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txt_forename;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox gb_startscreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ast1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.PictureBox pic_rules;
    }
}


namespace PeakPerformanceQuiz
{
    partial class frm_rulescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rulescreen));
            this.lbl_rules = new System.Windows.Forms.Label();
            this.lbl_allrules = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_howtoplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_rules
            // 
            this.lbl_rules.AutoSize = true;
            this.lbl_rules.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_rules.Location = new System.Drawing.Point(287, -10);
            this.lbl_rules.Name = "lbl_rules";
            this.lbl_rules.Size = new System.Drawing.Size(367, 168);
            this.lbl_rules.TabIndex = 0;
            this.lbl_rules.Text = "Rules";
            // 
            // lbl_allrules
            // 
            this.lbl_allrules.AutoSize = true;
            this.lbl_allrules.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allrules.Location = new System.Drawing.Point(36, 229);
            this.lbl_allrules.Name = "lbl_allrules";
            this.lbl_allrules.Size = new System.Drawing.Size(797, 408);
            this.lbl_allrules.TabIndex = 1;
            this.lbl_allrules.Text = resources.GetString("lbl_allrules.Text");
            this.lbl_allrules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.Red;
            this.lbl_close.Location = new System.Drawing.Point(830, 25);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(78, 84);
            this.lbl_close.TabIndex = 2;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_howtoplay
            // 
            this.lbl_howtoplay.AutoSize = true;
            this.lbl_howtoplay.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_howtoplay.Location = new System.Drawing.Point(356, 167);
            this.lbl_howtoplay.Name = "lbl_howtoplay";
            this.lbl_howtoplay.Size = new System.Drawing.Size(215, 46);
            this.lbl_howtoplay.TabIndex = 3;
            this.lbl_howtoplay.Text = "How to play?";
            // 
            // frm_rulescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 667);
            this.Controls.Add(this.lbl_howtoplay);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_allrules);
            this.Controls.Add(this.lbl_rules);
            this.Name = "frm_rulescreen";
            this.Text = "frm_rulescreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rules;
        private System.Windows.Forms.Label lbl_allrules;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_howtoplay;
    }
}
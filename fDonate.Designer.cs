﻿namespace meautosd
{
    partial class fDonate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDonate));
            this.label1 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.cbDontShowAgain = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btOK
            // 
            this.btOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Location = new System.Drawing.Point(130, 97);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(108, 22);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "Donate via PayPal";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // cbDontShowAgain
            // 
            this.cbDontShowAgain.AutoSize = true;
            this.cbDontShowAgain.Location = new System.Drawing.Point(15, 143);
            this.cbDontShowAgain.Name = "cbDontShowAgain";
            this.cbDontShowAgain.Size = new System.Drawing.Size(198, 17);
            this.cbDontShowAgain.TabIndex = 5;
            this.cbDontShowAgain.Text = "Dont show this again on next startup\r\n";
            this.cbDontShowAgain.UseVisualStyleBackColor = true;
            this.cbDontShowAgain.CheckedChanged += new System.EventHandler(this.cbDontShowAgain_CheckedChanged);
            // 
            // fDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(381, 172);
            this.Controls.Add(this.cbDontShowAgain);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fDonate";
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.fDonate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.CheckBox cbDontShowAgain;
    }
}
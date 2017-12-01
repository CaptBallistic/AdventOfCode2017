namespace AdventOfCode2017
{
    partial class UI
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
            this.btnGo = new System.Windows.Forms.Button();
            this.rbtnChallenge1 = new System.Windows.Forms.RadioButton();
            this.rbtChallenge2 = new System.Windows.Forms.RadioButton();
            this.challengeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(162, 103);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.startProcess);
            // 
            // rbtnChallenge1
            // 
            this.rbtnChallenge1.AutoSize = true;
            this.rbtnChallenge1.Checked = true;
            this.rbtnChallenge1.Location = new System.Drawing.Point(12, 59);
            this.rbtnChallenge1.Name = "rbtnChallenge1";
            this.rbtnChallenge1.Size = new System.Drawing.Size(81, 17);
            this.rbtnChallenge1.TabIndex = 2;
            this.rbtnChallenge1.TabStop = true;
            this.rbtnChallenge1.Text = "Challenge 1";
            this.rbtnChallenge1.UseVisualStyleBackColor = true;
            // 
            // rbtChallenge2
            // 
            this.rbtChallenge2.AutoSize = true;
            this.rbtChallenge2.Location = new System.Drawing.Point(12, 82);
            this.rbtChallenge2.Name = "rbtChallenge2";
            this.rbtChallenge2.Size = new System.Drawing.Size(81, 17);
            this.rbtChallenge2.TabIndex = 3;
            this.rbtChallenge2.Text = "Challenge 2";
            this.rbtChallenge2.UseVisualStyleBackColor = true;
            // 
            // challengeSelect
            // 
            this.challengeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.challengeSelect.FormattingEnabled = true;
            this.challengeSelect.Location = new System.Drawing.Point(12, 23);
            this.challengeSelect.Name = "challengeSelect";
            this.challengeSelect.Size = new System.Drawing.Size(121, 21);
            this.challengeSelect.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Challenge Number";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.challengeSelect);
            this.Controls.Add(this.rbtChallenge2);
            this.Controls.Add(this.rbtnChallenge1);
            this.Controls.Add(this.btnGo);
            this.Name = "UI";
            this.Text = "Advent of Code 2017";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rbtnChallenge1;
        private System.Windows.Forms.RadioButton rbtChallenge2;
        private System.Windows.Forms.ComboBox challengeSelect;
        private System.Windows.Forms.Label label1;
    }
}


using System.Windows.Forms;

namespace JeuWinForms {
    partial class FrmGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pKeyboard = new System.Windows.Forms.Panel();
            this.pDef = new System.Windows.Forms.Panel();
            this.pWord = new System.Windows.Forms.Panel();
            this.pTries = new System.Windows.Forms.Panel();
            this.pTimer = new System.Windows.Forms.Panel();
            this.lTimer = new System.Windows.Forms.Label();
            this.pRounds = new System.Windows.Forms.Panel();
            this.pTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pKeyboard
            // 
            this.pKeyboard.BackColor = System.Drawing.SystemColors.Control;
            this.pKeyboard.Location = new System.Drawing.Point(141, 514);
            this.pKeyboard.Name = "pKeyboard";
            this.pKeyboard.Size = new System.Drawing.Size(800, 229);
            this.pKeyboard.TabIndex = 3;
            // 
            // pDef
            // 
            this.pDef.Location = new System.Drawing.Point(141, 333);
            this.pDef.Name = "pDef";
            this.pDef.Size = new System.Drawing.Size(800, 175);
            this.pDef.TabIndex = 4;
            // 
            // pWord
            // 
            this.pWord.Location = new System.Drawing.Point(90, 227);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(900, 100);
            this.pWord.TabIndex = 5;
            // 
            // pTries
            // 
            this.pTries.Location = new System.Drawing.Point(163, 121);
            this.pTries.Name = "pTries";
            this.pTries.Size = new System.Drawing.Size(754, 100);
            this.pTries.TabIndex = 7;
            // 
            // pTimer
            // 
            this.pTimer.Controls.Add(this.lTimer);
            this.pTimer.Location = new System.Drawing.Point(7, 121);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(150, 100);
            this.pTimer.TabIndex = 6;
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.Location = new System.Drawing.Point(42, 38);
            this.lTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(0, 20);
            this.lTimer.TabIndex = 0;
            // 
            // pRounds
            // 
            this.pRounds.Location = new System.Drawing.Point(923, 121);
            this.pRounds.Name = "pRounds";
            this.pRounds.Size = new System.Drawing.Size(150, 100);
            this.pRounds.TabIndex = 8;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 769);
            this.Controls.Add(this.pRounds);
            this.Controls.Add(this.pDef);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.pTries);
            this.Controls.Add(this.pTimer);
            this.Controls.Add(this.pKeyboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGame";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Text = "Quinto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_Close);
            this.pTimer.ResumeLayout(false);
            this.pTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pKeyboard;
        private Panel pDef;
        private Panel pWord;
        private Panel pTries;
        private Panel pTimer;
        private Label lTimer;
        private Panel pRounds;
    }
}
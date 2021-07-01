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
            this.bRestart = new MaterialSkin.Controls.MaterialButton();
            this.pTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pKeyboard
            // 
            this.pKeyboard.BackColor = System.Drawing.SystemColors.Control;
            this.pKeyboard.Location = new System.Drawing.Point(94, 334);
            this.pKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.pKeyboard.Name = "pKeyboard";
            this.pKeyboard.Size = new System.Drawing.Size(533, 149);
            this.pKeyboard.TabIndex = 3;
            // 
            // pDef
            // 
            this.pDef.Location = new System.Drawing.Point(94, 216);
            this.pDef.Margin = new System.Windows.Forms.Padding(2);
            this.pDef.Name = "pDef";
            this.pDef.Size = new System.Drawing.Size(533, 114);
            this.pDef.TabIndex = 4;
            // 
            // pWord
            // 
            this.pWord.Location = new System.Drawing.Point(60, 148);
            this.pWord.Margin = new System.Windows.Forms.Padding(2);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(600, 65);
            this.pWord.TabIndex = 5;
            // 
            // pTries
            // 
            this.pTries.Location = new System.Drawing.Point(109, 79);
            this.pTries.Margin = new System.Windows.Forms.Padding(2);
            this.pTries.Name = "pTries";
            this.pTries.Size = new System.Drawing.Size(503, 65);
            this.pTries.TabIndex = 7;
            // 
            // pTimer
            // 
            this.pTimer.Controls.Add(this.lTimer);
            this.pTimer.Location = new System.Drawing.Point(5, 79);
            this.pTimer.Margin = new System.Windows.Forms.Padding(2);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(100, 65);
            this.pTimer.TabIndex = 6;
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.Location = new System.Drawing.Point(28, 25);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(0, 13);
            this.lTimer.TabIndex = 0;
            // 
            // pRounds
            // 
            this.pRounds.Location = new System.Drawing.Point(615, 79);
            this.pRounds.Margin = new System.Windows.Forms.Padding(2);
            this.pRounds.Name = "pRounds";
            this.pRounds.Size = new System.Drawing.Size(100, 65);
            this.pRounds.TabIndex = 8;
            // 
            // bRestart
            // 
            this.bRestart.AutoSize = false;
            this.bRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRestart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bRestart.Depth = 0;
            this.bRestart.HighEmphasis = true;
            this.bRestart.Icon = null;
            this.bRestart.Location = new System.Drawing.Point(633, 408);
            this.bRestart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bRestart.MouseState = MaterialSkin.MouseState.HOVER;
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(75, 75);
            this.bRestart.TabIndex = 9;
            this.bRestart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bRestart.UseAccentColor = false;
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Visible = false;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.pRounds);
            this.Controls.Add(this.pDef);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.pTries);
            this.Controls.Add(this.pTimer);
            this.Controls.Add(this.pKeyboard);
            this.Name = "FrmGame";
            this.Text = "Quinto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGameClose);
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
        private MaterialSkin.Controls.MaterialButton bRestart;
    }
}

using System.Drawing;
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
            this.pData = new System.Windows.Forms.Panel();
            this.pTimer = new System.Windows.Forms.Panel();
            this.lTimer = new System.Windows.Forms.Label();
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
            this.pDef.Location = new System.Drawing.Point(94, 230);
            this.pDef.Margin = new System.Windows.Forms.Padding(2);
            this.pDef.Name = "pDef";
            this.pDef.Size = new System.Drawing.Size(533, 100);
            this.pDef.TabIndex = 4;
            // 
            // pWord
            // 
            this.pWord.Location = new System.Drawing.Point(96, 161);
            this.pWord.Margin = new System.Windows.Forms.Padding(2);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(533, 65);
            this.pWord.TabIndex = 5;
            // 
            // pData
            // 
            this.pData.Location = new System.Drawing.Point(94, 79);
            this.pData.Margin = new System.Windows.Forms.Padding(2);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(533, 65);
            this.pData.TabIndex = 7;
            // 
            // pTimer
            // 
            this.pTimer.Controls.Add(this.lTimer);
            this.pTimer.Location = new System.Drawing.Point(5, 79);
            this.pTimer.Margin = new System.Windows.Forms.Padding(2);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(85, 65);
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
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.pDef);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.pTimer);
            this.Controls.Add(this.pKeyboard);
            this.Name = "FrmGame";
            this.Text = "Quinto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_Close);
            this.pTimer.ResumeLayout(false);
            this.pTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pKeyboard;
        private Panel pDef;
        private Panel pWord;
        private Panel pData;
        private Panel pTimer;
        private Label lTimer;
    }
}
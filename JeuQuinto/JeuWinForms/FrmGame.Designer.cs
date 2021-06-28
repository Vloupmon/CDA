
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
            this.pTimer = new System.Windows.Forms.Panel();
            this.pData = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pKeyboard
            // 
            this.pKeyboard.BackColor = System.Drawing.SystemColors.Control;
            this.pKeyboard.Location = new System.Drawing.Point(140, 462);
            this.pKeyboard.Name = "pKeyboard";
            this.pKeyboard.Size = new System.Drawing.Size(800, 230);
            this.pKeyboard.TabIndex = 3;
            // 
            // pDef
            // 
            this.pDef.Location = new System.Drawing.Point(140, 356);
            this.pDef.Name = "pDef";
            this.pDef.Size = new System.Drawing.Size(800, 100);
            this.pDef.TabIndex = 4;
            // 
            // pWord
            // 
            this.pWord.Location = new System.Drawing.Point(140, 176);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(800, 174);
            this.pWord.TabIndex = 5;
            // 
            // pTimer
            // 
            this.pTimer.Location = new System.Drawing.Point(7, 70);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(127, 100);
            this.pTimer.TabIndex = 6;
            // 
            // pData
            // 
            this.pData.Location = new System.Drawing.Point(140, 70);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(800, 100);
            this.pData.TabIndex = 7;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.pTimer);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.pDef);
            this.Controls.Add(this.pKeyboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGame";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Text = "Quinto";
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pKeyboard;
        private Panel pDef;
        private Panel pWord;
        private Panel pTimer;
        private Panel pData;
    }
}
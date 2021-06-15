
using System;

namespace WinForms_chaine {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.NumericUpDown();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position du caractère :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Résultat";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(142, 41);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(280, 23);
            this.inputBox.TabIndex = 3;
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(142, 111);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(280, 23);
            this.pos.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(142, 181);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(280, 23);
            this.resultBox.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(149, 226);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(136, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Catégorie du caractère";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.NumericUpDown pos;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btn;
    }
}


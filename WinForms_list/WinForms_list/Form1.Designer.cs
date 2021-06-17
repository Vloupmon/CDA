
using System.Windows.Forms;

namespace WinForms_list {
    partial class Form1 {
        private System.Windows.Forms.Button btnAllToLeft;

        private System.Windows.Forms.Button btnAllToRight;

        private System.Windows.Forms.Button btnDown;

        private System.Windows.Forms.Button btnOneToLeft;

        private System.Windows.Forms.Button btnOneToRight;

        private System.Windows.Forms.Button btnUp;

        private System.Windows.Forms.ComboBox comboBox;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox listBox;

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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnOneToRight = new System.Windows.Forms.Button();
            this.btnAllToRight = new System.Windows.Forms.Button();
            this.btnOneToLeft = new System.Windows.Forms.Button();
            this.btnAllToLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 45);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(300, 23);
            this.comboBox.TabIndex = 0;
            this.comboBox.DisplayMember = "Str";
            this.comboBox.KeyPress += new KeyPressEventHandler(comboKeyPress);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(488, 45);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(300, 364);
            this.listBox.TabIndex = 1;
            this.listBox.DisplayMember = "Str";
            // 
            // btnOneToRight
            // 
            this.btnOneToRight.Location = new System.Drawing.Point(318, 44);
            this.btnOneToRight.Name = "btnOneToRight";
            this.btnOneToRight.Size = new System.Drawing.Size(164, 23);
            this.btnOneToRight.TabIndex = 2;
            this.btnOneToRight.Text = ">";
            this.btnOneToRight.UseVisualStyleBackColor = true;
            this.btnOneToRight.Click += new System.EventHandler(this.btnClick);
            // 
            // btnAllToRight
            // 
            this.btnAllToRight.Location = new System.Drawing.Point(318, 73);
            this.btnAllToRight.Name = "btnAllToRight";
            this.btnAllToRight.Size = new System.Drawing.Size(164, 23);
            this.btnAllToRight.TabIndex = 3;
            this.btnAllToRight.Text = ">>";
            this.btnAllToRight.UseVisualStyleBackColor = true;
            this.btnAllToRight.Click += new System.EventHandler(this.btnClick);
            // 
            // btnOneToLeft
            // 
            this.btnOneToLeft.Location = new System.Drawing.Point(318, 357);
            this.btnOneToLeft.Name = "btnOneToLeft";
            this.btnOneToLeft.Size = new System.Drawing.Size(164, 23);
            this.btnOneToLeft.TabIndex = 4;
            this.btnOneToLeft.Text = "<";
            this.btnOneToLeft.UseVisualStyleBackColor = true;
            this.btnOneToLeft.Click += new System.EventHandler(this.btnClick);
            // 
            // btnAllToLeft
            // 
            this.btnAllToLeft.Location = new System.Drawing.Point(318, 386);
            this.btnAllToLeft.Name = "btnAllToLeft";
            this.btnAllToLeft.Size = new System.Drawing.Size(164, 23);
            this.btnAllToLeft.TabIndex = 5;
            this.btnAllToLeft.Text = "<<";
            this.btnAllToLeft.UseVisualStyleBackColor = true;
            this.btnAllToLeft.Click += new System.EventHandler(this.btnClick);
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(488, 415);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(147, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnClick);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(641, 415);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(147, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Target";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAllToLeft);
            this.Controls.Add(this.btnOneToLeft);
            this.Controls.Add(this.btnAllToRight);
            this.Controls.Add(this.btnOneToRight);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}



namespace Bibliotheque.WinUI {
    partial class FrmAdherents {
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
            this.subBox = new System.Windows.Forms.ListBox();
            this.booksButton = new System.Windows.Forms.Button();
            this.loanBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subBox
            // 
            this.subBox.FormattingEnabled = true;
            this.subBox.Location = new System.Drawing.Point(12, 38);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(277, 407);
            this.subBox.TabIndex = 0;
            this.subBox.SelectedIndexChanged += new System.EventHandler(this.subBox_SelectedIndexChanged);
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(650, 65);
            this.booksButton.Name = "booksButtton";
            this.booksButton.Size = new System.Drawing.Size(75, 23);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Valider";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // loanBox
            // 
            this.loanBox.FormattingEnabled = true;
            this.loanBox.Location = new System.Drawing.Point(295, 38);
            this.loanBox.Name = "loanBox";
            this.loanBox.Size = new System.Drawing.Size(279, 407);
            this.loanBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adhérents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emprunts";
            // 
            // booksComboBox
            // 
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(580, 38);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(208, 21);
            this.booksComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Emprunter";
            // 
            // FrmAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.booksComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loanBox);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.subBox);
            this.Name = "FrmAdherents";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox subBox;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.ListBox loanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox booksComboBox;
        private System.Windows.Forms.Label label3;
    }
}
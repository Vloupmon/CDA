
namespace WinForms_chaines2 {
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtStr1 = new System.Windows.Forms.TextBox();
            this.txtStr2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxOptions = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.boxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(199, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 23);
            this.txtInput.TabIndex = 0;
            // 
            // txtStr1
            // 
            this.txtStr1.Location = new System.Drawing.Point(199, 81);
            this.txtStr1.Name = "txtStr1";
            this.txtStr1.Size = new System.Drawing.Size(300, 23);
            this.txtStr1.TabIndex = 1;
            // 
            // txtStr2
            // 
            this.txtStr2.Location = new System.Drawing.Point(199, 137);
            this.txtStr2.Name = "txtStr2";
            this.txtStr2.Size = new System.Drawing.Size(300, 23);
            this.txtStr2.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(199, 193);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(300, 23);
            this.txtResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Portion de chaîne 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Portion de remplacement 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Résultat";
            // 
            // boxOptions
            // 
            this.boxOptions.Controls.Add(this.rb4);
            this.boxOptions.Controls.Add(this.rb3);
            this.boxOptions.Controls.Add(this.rb2);
            this.boxOptions.Controls.Add(this.rb1);
            this.boxOptions.Location = new System.Drawing.Point(36, 243);
            this.boxOptions.Name = "boxOptions";
            this.boxOptions.Size = new System.Drawing.Size(463, 234);
            this.boxOptions.TabIndex = 8;
            this.boxOptions.TabStop = false;
            this.boxOptions.Text = "Faites votre choix";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(7, 191);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(239, 19);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "Remplacer dernière occurence de 1 par 2";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(7, 135);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(243, 19);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Remplacer première occurence de 1 par 2";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(7, 79);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(251, 19);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Remplacer toutes les occurences de 1 par 2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(7, 23);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(141, 19);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Nombre occurences 1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(230, 512);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 9;
            this.btn.Text = "Jouer";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.boxOptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtStr2);
            this.Controls.Add(this.txtStr1);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxOptions.ResumeLayout(false);
            this.boxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtStr1;
        private System.Windows.Forms.TextBox txtStr2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox boxOptions;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btn;
    }
}


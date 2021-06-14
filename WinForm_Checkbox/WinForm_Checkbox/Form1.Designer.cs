
namespace WinForm_Checkbox {
    partial class CheckboxForm {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxChoice = new System.Windows.Forms.GroupBox();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.cbCharColour = new System.Windows.Forms.CheckBox();
            this.cbBGColour = new System.Windows.Forms.CheckBox();
            this.boxBG = new System.Windows.Forms.GroupBox();
            this.rbBGBlue = new System.Windows.Forms.RadioButton();
            this.rbBGGreen = new System.Windows.Forms.RadioButton();
            this.rbBGRed = new System.Windows.Forms.RadioButton();
            this.boxChar = new System.Windows.Forms.GroupBox();
            this.rbCharBlack = new System.Windows.Forms.RadioButton();
            this.rbCharWhite = new System.Windows.Forms.RadioButton();
            this.rbCharRed = new System.Windows.Forms.RadioButton();
            this.boxCase = new System.Windows.Forms.GroupBox();
            this.rbCaseCapital = new System.Windows.Forms.RadioButton();
            this.rbCaseMinuscule = new System.Windows.Forms.RadioButton();
            this.boxChoice.SuspendLayout();
            this.boxBG.SuspendLayout();
            this.boxChar.SuspendLayout();
            this.boxCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tapez votre texte";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(379, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "                                 ";
            // 
            // boxChoice
            // 
            this.boxChoice.Controls.Add(this.cbCase);
            this.boxChoice.Controls.Add(this.cbCharColour);
            this.boxChoice.Controls.Add(this.cbBGColour);
            this.boxChoice.Enabled = false;
            this.boxChoice.Location = new System.Drawing.Point(590, 41);
            this.boxChoice.Name = "boxChoice";
            this.boxChoice.Size = new System.Drawing.Size(198, 100);
            this.boxChoice.TabIndex = 5;
            this.boxChoice.TabStop = false;
            this.boxChoice.Text = "Choix";
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Location = new System.Drawing.Point(6, 72);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(56, 19);
            this.cbCase.TabIndex = 2;
            this.cbCase.Text = "Casse";
            this.cbCase.UseVisualStyleBackColor = true;
            this.cbCase.CheckedChanged += new System.EventHandler(this.cbCase_CheckedChanged);
            // 
            // cbCharColour
            // 
            this.cbCharColour.AutoSize = true;
            this.cbCharColour.Location = new System.Drawing.Point(6, 47);
            this.cbCharColour.Name = "cbCharColour";
            this.cbCharColour.Size = new System.Drawing.Size(145, 19);
            this.cbCharColour.TabIndex = 1;
            this.cbCharColour.Text = "Couleur des caractères";
            this.cbCharColour.UseVisualStyleBackColor = true;
            this.cbCharColour.CheckedChanged += new System.EventHandler(this.cbCharColour_CheckedChanged);
            // 
            // cbBGColour
            // 
            this.cbBGColour.AutoSize = true;
            this.cbBGColour.Location = new System.Drawing.Point(6, 22);
            this.cbBGColour.Name = "cbBGColour";
            this.cbBGColour.Size = new System.Drawing.Size(113, 19);
            this.cbBGColour.TabIndex = 0;
            this.cbBGColour.Text = "Couleur du fond";
            this.cbBGColour.UseVisualStyleBackColor = true;
            this.cbBGColour.CheckedChanged += new System.EventHandler(this.cbBGColour_CheckedChanged);
            // 
            // boxBG
            // 
            this.boxBG.Controls.Add(this.rbBGBlue);
            this.boxBG.Controls.Add(this.rbBGGreen);
            this.boxBG.Controls.Add(this.rbBGRed);
            this.boxBG.Location = new System.Drawing.Point(48, 330);
            this.boxBG.Name = "boxBG";
            this.boxBG.Size = new System.Drawing.Size(113, 108);
            this.boxBG.TabIndex = 6;
            this.boxBG.TabStop = false;
            this.boxBG.Text = "Fond";
            this.boxBG.Visible = false;
            // 
            // rbBGBlue
            // 
            this.rbBGBlue.AutoSize = true;
            this.rbBGBlue.Location = new System.Drawing.Point(7, 75);
            this.rbBGBlue.Name = "rbBGBlue";
            this.rbBGBlue.Size = new System.Drawing.Size(48, 19);
            this.rbBGBlue.TabIndex = 2;
            this.rbBGBlue.TabStop = true;
            this.rbBGBlue.Text = "Bleu";
            this.rbBGBlue.UseVisualStyleBackColor = true;
            this.rbBGBlue.CheckedChanged += new System.EventHandler(this.rbBGBlue_CheckedChanged);
            // 
            // rbBGGreen
            // 
            this.rbBGGreen.AutoSize = true;
            this.rbBGGreen.Location = new System.Drawing.Point(7, 49);
            this.rbBGGreen.Name = "rbBGGreen";
            this.rbBGGreen.Size = new System.Drawing.Size(45, 19);
            this.rbBGGreen.TabIndex = 1;
            this.rbBGGreen.TabStop = true;
            this.rbBGGreen.Text = "Vert";
            this.rbBGGreen.UseVisualStyleBackColor = true;
            this.rbBGGreen.CheckedChanged += new System.EventHandler(this.rbBGGreen_CheckedChanged);
            // 
            // rbBGRed
            // 
            this.rbBGRed.AutoSize = true;
            this.rbBGRed.Location = new System.Drawing.Point(7, 23);
            this.rbBGRed.Name = "rbBGRed";
            this.rbBGRed.Size = new System.Drawing.Size(59, 19);
            this.rbBGRed.TabIndex = 0;
            this.rbBGRed.TabStop = true;
            this.rbBGRed.Text = "Rouge";
            this.rbBGRed.UseVisualStyleBackColor = true;
            this.rbBGRed.CheckedChanged += new System.EventHandler(this.rbBGRed_CheckedChanged);
            // 
            // boxChar
            // 
            this.boxChar.Controls.Add(this.rbCharBlack);
            this.boxChar.Controls.Add(this.rbCharWhite);
            this.boxChar.Controls.Add(this.rbCharRed);
            this.boxChar.Location = new System.Drawing.Point(167, 330);
            this.boxChar.Name = "boxChar";
            this.boxChar.Size = new System.Drawing.Size(113, 108);
            this.boxChar.TabIndex = 7;
            this.boxChar.TabStop = false;
            this.boxChar.Text = "Caractères";
            this.boxChar.Visible = false;
            // 
            // rbCharBlack
            // 
            this.rbCharBlack.AutoSize = true;
            this.rbCharBlack.Location = new System.Drawing.Point(7, 75);
            this.rbCharBlack.Name = "rbCharBlack";
            this.rbCharBlack.Size = new System.Drawing.Size(48, 19);
            this.rbCharBlack.TabIndex = 2;
            this.rbCharBlack.TabStop = true;
            this.rbCharBlack.Text = "Noir";
            this.rbCharBlack.UseVisualStyleBackColor = true;
            this.rbCharBlack.CheckedChanged += new System.EventHandler(this.rbCharBlack_CheckedChanged);
            // 
            // rbCharWhite
            // 
            this.rbCharWhite.AutoSize = true;
            this.rbCharWhite.Location = new System.Drawing.Point(7, 49);
            this.rbCharWhite.Name = "rbCharWhite";
            this.rbCharWhite.Size = new System.Drawing.Size(54, 19);
            this.rbCharWhite.TabIndex = 1;
            this.rbCharWhite.TabStop = true;
            this.rbCharWhite.Text = "Blanc";
            this.rbCharWhite.UseVisualStyleBackColor = true;
            this.rbCharWhite.CheckedChanged += new System.EventHandler(this.rbCharWhite_CheckedChanged);
            // 
            // rbCharRed
            // 
            this.rbCharRed.AutoSize = true;
            this.rbCharRed.Location = new System.Drawing.Point(7, 23);
            this.rbCharRed.Name = "rbCharRed";
            this.rbCharRed.Size = new System.Drawing.Size(59, 19);
            this.rbCharRed.TabIndex = 0;
            this.rbCharRed.TabStop = true;
            this.rbCharRed.Text = "Rouge";
            this.rbCharRed.UseVisualStyleBackColor = true;
            this.rbCharRed.CheckedChanged += new System.EventHandler(this.rbCharRed_CheckedChanged);
            // 
            // boxCase
            // 
            this.boxCase.Controls.Add(this.rbCaseCapital);
            this.boxCase.Controls.Add(this.rbCaseMinuscule);
            this.boxCase.Location = new System.Drawing.Point(286, 353);
            this.boxCase.Name = "boxCase";
            this.boxCase.Size = new System.Drawing.Size(113, 71);
            this.boxCase.TabIndex = 8;
            this.boxCase.TabStop = false;
            this.boxCase.Text = "Casse";
            this.boxCase.Visible = false;
            // 
            // rbCaseCapital
            // 
            this.rbCaseCapital.AutoSize = true;
            this.rbCaseCapital.Location = new System.Drawing.Point(6, 47);
            this.rbCaseCapital.Name = "rbCaseCapital";
            this.rbCaseCapital.Size = new System.Drawing.Size(84, 19);
            this.rbCaseCapital.TabIndex = 2;
            this.rbCaseCapital.TabStop = true;
            this.rbCaseCapital.Text = "Majuscules";
            this.rbCaseCapital.UseVisualStyleBackColor = true;
            this.rbCaseCapital.CheckedChanged += new System.EventHandler(this.rbCaseCapital_CheckedChanged);
            // 
            // rbCaseMinuscule
            // 
            this.rbCaseMinuscule.AutoSize = true;
            this.rbCaseMinuscule.Location = new System.Drawing.Point(6, 22);
            this.rbCaseMinuscule.Name = "rbCaseMinuscule";
            this.rbCaseMinuscule.Size = new System.Drawing.Size(85, 19);
            this.rbCaseMinuscule.TabIndex = 1;
            this.rbCaseMinuscule.TabStop = true;
            this.rbCaseMinuscule.Text = "Minuscules";
            this.rbCaseMinuscule.UseVisualStyleBackColor = true;
            this.rbCaseMinuscule.CheckedChanged += new System.EventHandler(this.rbCaseMinuscule_CheckedChanged);
            // 
            // CheckboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxCase);
            this.Controls.Add(this.boxChar);
            this.Controls.Add(this.boxBG);
            this.Controls.Add(this.boxChoice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "CheckboxForm";
            this.Text = "   ";
            this.boxChoice.ResumeLayout(false);
            this.boxChoice.PerformLayout();
            this.boxBG.ResumeLayout(false);
            this.boxBG.PerformLayout();
            this.boxChar.ResumeLayout(false);
            this.boxChar.PerformLayout();
            this.boxCase.ResumeLayout(false);
            this.boxCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox boxChoice;
        private System.Windows.Forms.CheckBox cbCase;
        private System.Windows.Forms.CheckBox cbCharColour;
        private System.Windows.Forms.CheckBox cbBGColour;
        private System.Windows.Forms.GroupBox boxBG;
        private System.Windows.Forms.RadioButton rbBGBlue;
        private System.Windows.Forms.RadioButton rbBGGreen;
        private System.Windows.Forms.RadioButton rbBGRed;
        private System.Windows.Forms.GroupBox boxChar;
        private System.Windows.Forms.RadioButton rbCharBlack;
        private System.Windows.Forms.RadioButton rbCharWhite;
        private System.Windows.Forms.RadioButton rbCharRed;
        private System.Windows.Forms.GroupBox boxCase;
        private System.Windows.Forms.RadioButton rbCaseCapital;
        private System.Windows.Forms.RadioButton rbCaseMinuscule;
    }
}


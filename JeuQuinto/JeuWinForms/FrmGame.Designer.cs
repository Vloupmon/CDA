
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
            this.gbKeyboard = new System.Windows.Forms.GroupBox();
            this.cbLayout = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // gbKeyboard
            // 
            this.gbKeyboard.Location = new System.Drawing.Point(175, 294);
            this.gbKeyboard.Name = "gbKeyboard";
            this.gbKeyboard.Size = new System.Drawing.Size(450, 150);
            this.gbKeyboard.TabIndex = 0;
            this.gbKeyboard.TabStop = false;
            this.gbKeyboard.Visible = false;
            // 
            // cbLayout
            // 
            this.cbLayout.AutoResize = false;
            this.cbLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLayout.Depth = 0;
            this.cbLayout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLayout.DropDownHeight = 174;
            this.cbLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayout.DropDownWidth = 121;
            this.cbLayout.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLayout.FormattingEnabled = true;
            this.cbLayout.IntegralHeight = false;
            this.cbLayout.ItemHeight = 43;
            this.cbLayout.Items.AddRange(new object[] {
            "QWERTY",
            "QWERTZ",
            "AZERTY"});
            this.cbLayout.Location = new System.Drawing.Point(6, 294);
            this.cbLayout.MaxDropDownItems = 4;
            this.cbLayout.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLayout.Name = "cbLayout";
            this.cbLayout.Size = new System.Drawing.Size(121, 49);
            this.cbLayout.StartIndex = 0;
            this.cbLayout.TabIndex = 1;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLayout);
            this.Controls.Add(this.gbKeyboard);
            this.Name = "FrmGame";
            this.Text = "Quinto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKeyboard;
        private MaterialSkin.Controls.MaterialComboBox cbLayout;
    }
}
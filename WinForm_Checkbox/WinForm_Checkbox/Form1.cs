using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm_Checkbox {

    public partial class CheckboxForm : Form {

        public CheckboxForm() {
            InitializeComponent();
        }

        private void resetText() {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            textBox2.Text = textBox1.Text;
            boxChoice.Enabled = true;
            if (textBox1.Text.Length == 0) {
                boxChoice.Enabled = false;
                textBox2.ForeColor = DefaultForeColor;
                textBox2.BackColor = DefaultBackColor;
                textBox2.CharacterCasing = CharacterCasing.Normal;
            }
        }

        private void cbBGColour_CheckedChanged(object sender, EventArgs e) {
            if (cbBGColour.Checked) {
                boxBG.Visible = true;
            } else {
                boxBG.Visible = false;
                textBox2.BackColor = DefaultBackColor;
                rbBGRed.Checked = false;
                rbBGGreen.Checked = false;
                rbBGBlue.Checked = false;
            }
        }

        private void cbCharColour_CheckedChanged(object sender, EventArgs e) {
            if (cbCharColour.Checked) {
                boxChar.Visible = true;
            } else {
                boxChar.Visible = false;
                textBox2.ForeColor = DefaultForeColor;
                rbCharRed.Checked = false;
                rbCharWhite.Checked = false;
                rbCharBlack.Checked = false;
            }
        }

        private void cbCase_CheckedChanged(object sender, EventArgs e) {
            if (cbCase.Checked) {
                boxCase.Visible = true;
            } else {
                boxCase.Visible = false;
                textBox2.CharacterCasing = CharacterCasing.Normal;
                rbCaseMinuscule.Checked = false;
                rbCaseCapital.Checked = false;
            }
        }

        private void rbBGRed_CheckedChanged(object sender, EventArgs e) {
            textBox2.BackColor = Color.Blue;
        }

        private void rbBGGreen_CheckedChanged(object sender, EventArgs e) {
            textBox2.BackColor = Color.Green;
        }

        private void rbBGBlue_CheckedChanged(object sender, EventArgs e) {
            textBox2.BackColor = Color.Blue;
        }

        private void rbCharRed_CheckedChanged(object sender, EventArgs e) {
            textBox2.ForeColor = Color.Red;
        }

        private void rbCharWhite_CheckedChanged(object sender, EventArgs e) {
            textBox2.ForeColor = Color.White;
        }

        private void rbCharBlack_CheckedChanged(object sender, EventArgs e) {
            textBox2.ForeColor = Color.Black;
        }

        private void rbCaseMinuscule_CheckedChanged(object sender, EventArgs e) {
            textBox2.CharacterCasing = CharacterCasing.Lower;
        }

        private void rbCaseCapital_CheckedChanged(object sender, EventArgs e) {
            textBox2.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Calc {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtBox.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            string[] buffer = txtBox.Text.Split(" = ");
            buffer = buffer[buffer.Length - 1].Split("+");
            int i = 0;
            foreach (string digit in buffer) {
                if (!String.IsNullOrEmpty(digit)) {
                    i += int.Parse(digit);
                }
            }
            txtBox.Text += String.Join("", " = ", i.ToString(), "+");
        }

        private void btn0_Click(object sender, EventArgs e) {
            txtBox.Text += "0+";
        }

        private void btn1_Click(object sender, EventArgs e) {
            txtBox.Text += "1+";
        }

        private void btn2_Click(object sender, EventArgs e) {
            txtBox.Text += "2+";
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtBox.Text += "3+";
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtBox.Text += "4+";
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtBox.Text += "5+";
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtBox.Text += "6+";
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtBox.Text += "7+";
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtBox.Text += "8+";
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtBox.Text += "9+";
        }
    }
}
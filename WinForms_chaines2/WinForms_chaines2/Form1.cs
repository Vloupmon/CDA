using System;
using System.Text;
using System.Text.RegularExpressions;

//using System.Linq;
using System.Windows.Forms;

namespace WinForms_chaines2 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        public void btnClick(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtInput.Text) && !String.IsNullOrEmpty(txtStr1.Text)) {
                if (rb1.Checked) {
                    txtResult.Text = Regex.Matches(txtInput.Text, txtStr1.Text).Count.ToString();
                }
                if (!String.IsNullOrEmpty(txtStr2.Text)) {
                    if (rb2.Checked) {
                        txtResult.Text = Regex.Replace(txtInput.Text, txtStr1.Text, txtStr2.Text);
                    }
                    if (rb3.Checked) {
                        var buffer = new StringBuilder(txtInput.Text);
                        buffer.Remove(Regex.Match(txtInput.Text, txtStr1.Text).Index, txtStr2.Text.Length);
                        buffer.Insert(Regex.Match(txtInput.Text, txtStr1.Text).Index, txtStr2.Text);
                        txtResult.Text = buffer.ToString();
                    }
                    if (rb4.Checked) {
                        var buffer = new StringBuilder(txtInput.Text);
                        buffer.Remove(Regex.Match(txtInput.Text, txtStr1.Text,
                            RegexOptions.RightToLeft).Index, txtStr2.Text.Length);
                        buffer.Insert(Regex.Match(txtInput.Text, txtStr1.Text,
                            RegexOptions.RightToLeft).Index, txtStr2.Text);
                        txtResult.Text = buffer.ToString();
                    }
                }
            }
        }
    }
}
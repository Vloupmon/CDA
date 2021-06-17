using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_modal {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 dialog = new();
            DialogResult result = dialog.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    txtResult.Text = "OK";
                    break;

                case DialogResult.Cancel:
                    txtResult.Text = "Cancel";
                    break;
            }
        }
    }
}
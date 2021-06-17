using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_modal {

    public partial class Form2 : Form {

        public Form2() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtID_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtID.Text)) {
                txtID.Select();
                errorProvider.SetError(txtID, "Champs vide !");
            } else if (Regex.IsMatch(txtID.Text, @"^[a-zA-Z][0-9a-zA-Z]{4}")) {
                txtPasswd.Select();
                errorProvider.SetError(txtID, "");
            } else {
                errorProvider.SetError(txtID, "Champs invalide !");
            }
        }

        private void txtPasswd_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtPasswd.Text)) {
                txtID.Select();
                errorProvider.SetError(txtPasswd, "Champs vide !");
            } else if (txtID.Text == txtPasswd.Text) {
                this.DialogResult = DialogResult.OK;
                errorProvider.SetError(txtID, "");
            } else {
                errorProvider.SetError(txtID, "Champs invalide !");
            }
        }
    }
}
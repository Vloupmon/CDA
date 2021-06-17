using CountryData.Standard;
using System;
using System.Windows.Forms;

namespace WinForms_list {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            CountryHelper helper = new();

            foreach (string country in helper.GetCountries()) {
                Wrapper wrapper = new();
                wrapper.Str = country;
                comboBox.Items.Add(wrapper);
                comboBox.SelectedIndex = 0;
            }
        }

        private void btnClick(object sender, EventArgs e) {
            Button btn = (Button)sender;
            switch (btn.Text) {
                case ">":
                    if (Wrapper.Flag == true && comboBox.Text.Length > 0 &&
                        comboBox.Text != comboBox.SelectedItem) {
                        Wrapper wrapper = new(comboBox.Text);
                        listBox.Items.Add(wrapper);
                    } else if (comboBox.Items.Count > 0) {
                        listBox.Items.Add(comboBox.SelectedItem);
                        comboBox.Items.Remove(comboBox.SelectedItem);
                        if (comboBox.Items.Count >= 1) {
                            comboBox.SelectedIndex = 0;
                        } else {
                            comboBox.Text = "";
                        }
                    }
                    break;

                case ">>":
                    if (comboBox.Items.Count > 0) {
                        foreach (object item in comboBox.Items) {
                            listBox.Items.Add(item);
                        }
                        comboBox.Items.Clear();
                        comboBox.Text = "";
                    }
                    break;

                case "<":
                    if (listBox.Items.Count > 0) {
                        if (listBox.SelectedItem == null) {
                            listBox.SelectedIndex = 0;
                        }
                        comboBox.Items.Add(listBox.SelectedItem);
                        comboBox.SelectedIndex = 0;
                        listBox.Items.Remove(listBox.SelectedItem);
                    }
                    break;

                case "<<":
                    if (listBox.Items.Count > 0) {
                        foreach (object item in listBox.Items) {
                            comboBox.Items.Add(item);
                        }
                        listBox.Items.Clear();
                        comboBox.SelectedIndex = 0;
                    }
                    break;

                case "Up":
                    break;

                case "Down":
                    break;
            }
        }

        private void comboKeyPress(object sender, KeyPressEventArgs e) {
            Wrapper.Flag = true;
        }
    }

    public class Wrapper {
        private static bool flag = false;
        private string str;

        public Wrapper() {
        }

        public Wrapper(string str) : base() {
            this.Str = str;
        }

        public static bool Flag {
            get => flag;
            set => flag = value;
        }

        public string Str {
            get => str;
            set => str = value;
        }
    }
}
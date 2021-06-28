using MaterialSkin;
using MaterialSkin.Controls;
using QuintoDLL;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JeuWinForms {

    public partial class FrmGame : MaterialForm {

        // No focus on show
        protected override bool ShowWithoutActivation {
            get {
                return true;
            }
        }

        readonly private string[] qwerty =
            { "QWERTYUIOP",
            "ASDFGHJKL",
            "ZXCVBN-"};

        readonly private string[] qwertz =
            { "QWERTZUIOP",
            "ASDFGHJKL",
            "YXCVBNM-"};

        readonly private string[] azerty =
            { "AZERTYUIOP",
            "QSDFGHJKLM",
            "WXCVBN-"};

        public void KeyboardGen(string[] layout) {
            int t = 0;
            for (int row = 0; row < layout.Count(); row++) {
                for (int col = 0; col < layout[row].Length; col++) {
                    Button btn = new Button {
                        Size = new Size(50, 50),
                        TabIndex = t++,
                        Text = layout[row][col].ToString()
                    };
                    // Offset keys
                    if (row == 1) {
                        btn.Left = col * btn.Size.Width + btn.Size.Width / 2;
                    } else if (row == 2) {
                        btn.Left = col * btn.Size.Width + btn.Size.Width;
                    } else {
                        btn.Left = col * btn.Size.Width;
                    }
                    btn.Top = row * btn.Size.Height;
                    pKeyboard.Controls.Add(btn);
                }
            }
        }

        public FrmGame() {
            Quinto quinto = new Quinto();

            InitializeComponent();
            var manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;

            string threadLang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            if (threadLang == "fr") {
                KeyboardGen(azerty);
            } else if (threadLang == "de") {
                KeyboardGen(qwertz);
            } else {
                KeyboardGen(qwerty);
            }
        }
    }
}
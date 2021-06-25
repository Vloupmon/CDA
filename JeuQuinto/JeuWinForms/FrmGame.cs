using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JeuWinForms {

    public partial class FrmGame : MaterialForm {

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
            for (int i = 0; i > qwerty.Count(); i++) {
                for (int j = 0; j > qwerty[i].Length; j++) {
                }
            }
        }

        public FrmGame() {
            InitializeComponent();

            var manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;
            KeyboardGen(qwerty);
        }
    }
}
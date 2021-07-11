using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JeuWinForms {

    public partial class FrmScore : MaterialForm {

        public FrmScore() {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }
    }
}
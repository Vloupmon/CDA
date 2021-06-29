using MaterialSkin;
using MaterialSkin.Controls;
using QuintoDLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace JeuWinForms {

    public partial class FrmGame : MaterialForm {

        readonly private string[] azerty =
            { "AZERTYUIOP",
            "QSDFGHJKLM",
            "WXCVBN-"};

        readonly private string[] qwerty =
            { "QWERTYUIOP",
            "ASDFGHJKL",
            "ZXCVBN-"};

        private Timer _roundTimer;
        private Quinto _session;

        public FrmGame() {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            manager.AddFormToManage(this);
            InitGame();
        }

        public Timer RoundTimer {
            get => _roundTimer;
            set => _roundTimer = value;
        }

        public Quinto Session {
            get => _session;
            set => _session = value;
        }

        // No focus on show
        protected override bool ShowWithoutActivation {
            get {
                return true;
            }
        }

        public void InitGame() {
            AppSettings appSettings = new AppSettings();
            UserSettings userSettings = new UserSettings();
            Session = new Quinto(appSettings.DicPath + "Dic" + userSettings.CurrentCulture + ".xml");
            RoundTimer = NewTimer();
            Session.NewRound();
            KeyboardGen(userSettings.CurrentCulture);
            WordGen();
        }

        public void KeyboardGen(string culture) {
            string[] layout;

            if (culture == "FR-fr") {
                layout = azerty;
            } else {
                layout = qwerty;
            }

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
                    btn.Click += new EventHandler(btnClick);
                    pKeyboard.Controls.Add(btn);
                }
            }
        }

        public Timer NewTimer() {
            Timer ret = new Timer {
                Interval = 1000,
                Enabled = true
            };
            ret.Tick += new EventHandler(timerTick);
            ret.Stop();
            ret.Start();
            return (ret);
        }

        public void WordGen() {
            int size = 24;
            int margin = 5;
            int offset = pWord.Size.Width / 2 - (Session.Round.Word.Mot.Length / 2 * (size + margin));

            pWord.Controls.Clear();
            for (int i = 0; i < Session.Round.Word.Mot.Length; i++) {
                MaterialLabel l = new MaterialLabel {
                    Text = Session.Round.Mask[i].ToString(),
                    Size = new Size(size, size),
                };
                l.Left = (i * l.Size.Width + 5) + offset;
                pWord.Controls.Add(l);
            }
        }

        private void btnClick(object sender, EventArgs e) {
            if (Session.Round.Masking((sender as Button).Text[0])) {
                WordGen();
                (sender as Button).BackColor = Color.Green;
            } else {
                (sender as Button).BackColor = Color.Red;
            }
                (sender as Button).Enabled = false;
        }

        private void FrmGame_Close(object sender, EventArgs e) {
            RoundTimer = null;
        }

        private void timerTick(object sender, EventArgs e) {
            lTimer.Text = "Score : " + Session.Game.Score++.ToString();
        }
    }
}
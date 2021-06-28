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
        private Timer _roundTimer;
        private Quinto _session;

        // No focus on show
        protected override bool ShowWithoutActivation {
            get {
                return true;
            }
        }

        public Timer RoundTimer {
            get => _roundTimer;
            set => _roundTimer = value;
        }

        public Quinto Session {
            get => _session;
            set => _session = value;
        }

        readonly private string[] qwerty =
            { "QWERTYUIOP",
            "ASDFGHJKL",
            "ZXCVBN-"};

        readonly private string[] azerty =
            { "AZERTYUIOP",
            "QSDFGHJKLM",
            "WXCVBN-"};

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
                    pKeyboard.Controls.Add(btn);
                }
            }
        }

        private void timerTick(object sender, EventArgs e) {
            lTimer.Text = "Score : " + Session.Game.Score++.ToString();
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
            for (int i = 0; i < 25; i++) {
                Label l = new Label {
                    Text = i.ToString(),
                    //Font = new Font("Arial", 16),
                    Size = new Size(15, 15),
                    BackColor = Color.Red
                };
                l.Left = i * l.Size.Width + 15;
                pWord.Controls.Add(l);
            }
            //pWord.Anchor = AnchorStyles.None;
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

        public FrmGame() {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            manager.AddFormToManage(this);
            InitGame();
        }

        private void FrmGame_Close(object sender, EventArgs e) {
            RoundTimer = null;
        }
    }
}
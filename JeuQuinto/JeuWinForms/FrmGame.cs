using GameSettings;
using MaterialSkin;
using MaterialSkin.Controls;
using QuintoDLL;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
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
        private UserSettings userSettings = new UserSettings();

        public FrmGame(AppSettings appSettings) {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            manager.AddFormToManage(this);

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(userSettings.CurrentCulture);
            Session = new Quinto(appSettings.DicPath + "Dic" + userSettings.CurrentCulture + ".xml");
            InitRound();
        }

        public void InitRound() {
            Session.Game.Rounds = userSettings.Rounds;
            Session.NewRound();
            Session.Round.Tries = userSettings.TriesPerRound;
            Session.Round.PointsPerTry = userSettings.PointsPerTry;
            Session.Round.StateChange += new EventHandler(OnStateChange);
            KeyboardGen(userSettings.CurrentCulture);
            UITextGen();
            MessageBox.Show(Session.Round.Word.Mot); // TRICHE
            RoundTimer = NewTimer();
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

        public void KeyboardGen(string culture) {
            string[] layout;

            if (culture == "FR-fr") {
                layout = azerty;
            } else {
                layout = qwerty;
            }

            pKeyboard.Controls.Clear();
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
                    btn.Click += new EventHandler(BtnClick);
                    pKeyboard.Controls.Add(btn);
                }
            }
        }

        public Timer NewTimer() {
            Timer ret = new Timer {
                Interval = 1000,
                Enabled = true
            };
            ret.Tick += new EventHandler(TimerTick);
            return (ret);
        }

        public void WordTextGen() {
            int size = 24;
            int margin = 5;
            int offset = pWord.Size.Width / 2 - (Session.Round.Mask.Length / 2 * (size + margin));

            pWord.Controls.Clear();
            for (int i = 0; i < Session.Round.Mask.Length; i++) {
                MaterialLabel l = new MaterialLabel {
                    Text = Session.Round.Mask[i].ToString(),
                    Size = new Size(size, size),
                };
                l.Left = (i * l.Size.Width + 5) + offset;
                pWord.Controls.Add(l);
            }
        }

        public void TimerTextGen() {
            pTimer.Controls.Clear();
            Label l = new Label {
                Text = string.Format("{0} : {1}", Properties.UIStrings.Score, Session.Game.Score.ToString())
            };
            l.Location = new Point(pTimer.Size.Width / 2 - l.Size.Width / 2,
                pTimer.Size.Height / 2 - l.Size.Height / 2);
            l.Anchor = AnchorStyles.None;
            pTimer.Controls.Add(l);
        }

        public void TriesTextGen() {
            pTries.Controls.Clear();
            Label l = new Label {
                Text = string.Format("{0} : {1}", Properties.UIStrings.Tries, Session.Round.Tries.ToString())
            };
            l.Location = new Point(pTries.Size.Width / 2 - l.Size.Width / 2,
                pTries.Size.Height / 2 - l.Size.Height / 2);
            l.Anchor = AnchorStyles.None;
            pTries.Controls.Add(l);
        }

        public void DefTextGen() {
            pDef.Controls.Clear();
            Label l = new Label {
                Text = string.Format("{0} :\n{1}", Properties.UIStrings.Def, Session.Round.Word.Definition)
            };
            l.Location = new Point(pDef.Size.Width / 2 - l.Size.Width / 2,
                pDef.Size.Height / 2 - l.Size.Height / 2);
            l.Anchor = AnchorStyles.None;
            pDef.Controls.Add(l);
        }

        public void RoundsTextGen() {
            pRounds.Controls.Clear();
            Label l = new Label {
                Text = string.Format("{0} : {1}", Properties.UIStrings.Rounds, Session.Game.Rounds.ToString())
            };
            l.Location = new Point(pRounds.Size.Width / 2 - l.Size.Width / 2,
                pRounds.Size.Height / 2 - l.Size.Height / 2);
            l.Anchor = AnchorStyles.None;
            pRounds.Controls.Add(l);
        }

        public void UITextGen() {
            WordTextGen();
            TimerTextGen();
            TriesTextGen();
            RoundsTextGen();
        }

        private void BtnClick(object sender, EventArgs e) {
            if (Session.RoundStateCalc((sender as Button).Text[0])) {
                (sender as Button).BackColor = Color.Green;
            } else {
                (sender as Button).BackColor = Color.Red;
            }
            (sender as Button).Enabled = false;
        }

        private void FrmGameClose(object sender, EventArgs e) {
            RoundTimer = null;
        }

        private void OnStateChange(object sender, EventArgs e) {
            switch ((sender as Round).State) {
                case States.Init:
                    UITextGen();
                    RoundTimer.Start();
                    break;

                case States.Valid:
                    RoundTimer.Stop();
                    UITextGen();
                    bRestart.Visible = true;
                    break;

                case States.Fail:
                    RoundTimer.Stop();
                    TriesTextGen();
                    DefTextGen();
                    WordTextGen();
                    break;
            }
        }

        private void TimerTick(object sender, EventArgs e) {
            Session.Game.Score += userSettings.PointsPerSec;
            TimerTextGen();
        }

        private void bRestart_Click(object sender, EventArgs e) {
            InitRound();
        }
    }
}
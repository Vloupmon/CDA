using System.Collections.Specialized;

namespace GameSettings {

    public class AppSettings {
        private StringCollection _cultures;
        private string _dicPath;
        private int _maxPointsPerTry;
        private int _maxPointsPerSec;
        private int _maxRounds;
        private int _minPointsPerTry;
        private int _minPointsPerSec;
        private int _minRounds;
        private int _minTriesPerRound;
        private int _maxTriesPerRound;

        public AppSettings() {
            DicPath = JeuWinForms.Properties.Settings.Default.RepertoireDictionnaires;
            Cultures = JeuWinForms.Properties.Settings.Default.Cultures;
            MinRounds = JeuWinForms.Properties.Settings.Default.NombreManchesMini;
            MaxRounds = JeuWinForms.Properties.Settings.Default.NombreManchesMaxi;
            MinPointsPerSec = JeuWinForms.Properties.Settings.Default.NombrePointsSecondeMini;
            MaxPointsPerSec = JeuWinForms.Properties.Settings.Default.NombrePointsSecondeMaxi;
            MinPointsPerTry = JeuWinForms.Properties.Settings.Default.NombrePointsErreurMini;
            MaxPointsPerTry = JeuWinForms.Properties.Settings.Default.NombrePointsErreurMaxi;
            MinTriesPerRound = JeuWinForms.Properties.Settings.Default.NombreErreursMini;
            MaxTriesPerRound = JeuWinForms.Properties.Settings.Default.NombreErreursMaxi;
        }

        public StringCollection Cultures {
            get => _cultures;
            set => _cultures = value;
        }

        public string DicPath {
            get => _dicPath;
            set => _dicPath = value;
        }

        public int MaxTriesPerRound {
            get => _maxTriesPerRound;
            set => _maxTriesPerRound = value;
        }

        public int MaxPointsPerTry {
            get => _maxPointsPerTry;
            set => _maxPointsPerTry = value;
        }

        public int MaxPointsPerSec {
            get => _maxPointsPerSec;
            set => _maxPointsPerSec = value;
        }

        public int MaxRounds {
            get => _maxRounds;
            set => _maxRounds = value;
        }

        public int MinTriesPerRound {
            get => _minTriesPerRound;
            set => _minTriesPerRound = value;
        }

        public int MinPointsPerTry {
            get => _minPointsPerTry;
            set => _minPointsPerTry = value;
        }

        public int MinPointsPerSec {
            get => _minPointsPerSec;
            set => _minPointsPerSec = value;
        }

        public int MinRounds {
            get => _minRounds;
            set => _minRounds = value;
        }
    }

    public class UserSettings {
        private string _currentCulture;
        private int _TriesPerRound;
        private int _PointsPerTry;
        private int _PointsPerSec;
        private int _rounds;

        public UserSettings() {
            CurrentCulture = JeuWinForms.Properties.Settings.Default.CultureCourante;
            Rounds = JeuWinForms.Properties.Settings.Default.NombreManches;
            PointsPerSec = JeuWinForms.Properties.Settings.Default.NombrePointsParSeconde;
            PointsPerTry = JeuWinForms.Properties.Settings.Default.NombrePointsErreur;
            TriesPerRound = JeuWinForms.Properties.Settings.Default.NombreErreurs;
        }

        public UserSettings(UserSettings userSettings) {
            CurrentCulture = userSettings.CurrentCulture;
            Rounds = userSettings.Rounds;
            PointsPerSec = userSettings.PointsPerSec;
            PointsPerTry = userSettings.PointsPerTry;
            TriesPerRound = userSettings.TriesPerRound;
        }

        public string CurrentCulture {
            get => _currentCulture;
            set => _currentCulture = value;
        }

        public int TriesPerRound {
            get => _TriesPerRound;
            set => _TriesPerRound = value;
        }

        public int PointsPerTry {
            get => _PointsPerTry;
            set => _PointsPerTry = value;
        }

        public int PointsPerSec {
            get => _PointsPerSec;
            set => _PointsPerSec = value;
        }

        public int Rounds {
            get => _rounds;
            set => _rounds = value;
        }
    }
}
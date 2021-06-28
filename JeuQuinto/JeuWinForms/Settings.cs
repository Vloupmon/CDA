using System.Collections.Specialized;

namespace JeuWinForms {

    public class AppSettings {
        private StringCollection _cultures;
        private string _dicPath;
        private int _maxMistakesPerRound;
        private int _maxPointsPerMistake;
        private int _maxPointsPerSec;
        private int _maxRounds;
        private int _minMistakesPerRound;
        private int _minPointsPerMistake;
        private int _minPointsPerSec;
        private int _minRounds;

        public AppSettings() {
            DicPath = Properties.Settings.Default.RepertoireDictionnaires;
            Cultures = Properties.Settings.Default.Cultures;
            MinRounds = Properties.Settings.Default.NombreManchesMini;
            MaxRounds = Properties.Settings.Default.NombreManchesMaxi;
            MinPointsPerSec = Properties.Settings.Default.NombrePointsSecondeMini;
            MaxPointsPerSec = Properties.Settings.Default.NombrePointsSecondeMaxi;
            MinPointsPerMistake = Properties.Settings.Default.NombrePointsErreurMini;
            MaxPointsPerMistake = Properties.Settings.Default.NombrePointsErreurMaxi;
            MinMistakesPerRound = Properties.Settings.Default.NombreErreursMini;
            MaxMistakesPerRound = Properties.Settings.Default.NombreErreursMaxi;
        }

        public StringCollection Cultures {
            get => _cultures;
            set => _cultures = value;
        }

        public string DicPath {
            get => _dicPath;
            set => _dicPath = value;
        }

        public int MaxMistakesPerRound {
            get => _maxMistakesPerRound;
            set => _maxMistakesPerRound = value;
        }

        public int MaxPointsPerMistake {
            get => _maxPointsPerMistake;
            set => _maxPointsPerMistake = value;
        }

        public int MaxPointsPerSec {
            get => _maxPointsPerSec;
            set => _maxPointsPerSec = value;
        }

        public int MaxRounds {
            get => _maxRounds;
            set => _maxRounds = value;
        }

        public int MinMistakesPerRound {
            get => _minMistakesPerRound;
            set => _minMistakesPerRound = value;
        }

        public int MinPointsPerMistake {
            get => _minPointsPerMistake;
            set => _minPointsPerMistake = value;
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
        private int _MistakesPerRound;
        private int _PointsPerMistake;
        private int _PointsPerSec;
        private int _rounds;

        public UserSettings() {
            CurrentCulture = Properties.Settings.Default.CultureCourante;
            Rounds = Properties.Settings.Default.NombreManches;
            PointsPerSec = Properties.Settings.Default.NombrePointsParSeconde;
            PointsPerMistake = Properties.Settings.Default.NombrePointsErreur;
            MistakesPerRound = Properties.Settings.Default.NombreErreurs;
        }

        public string CurrentCulture {
            get => _currentCulture;
            set => _currentCulture = value;
        }

        public int MistakesPerRound {
            get => _MistakesPerRound;
            set => _MistakesPerRound = value;
        }

        public int PointsPerMistake {
            get => _PointsPerMistake;
            set => _PointsPerMistake = value;
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
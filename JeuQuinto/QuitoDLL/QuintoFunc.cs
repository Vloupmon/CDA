using DictionnaireDLL;
using System.Globalization;
using System.Text;

namespace QuintoDLL {

    public class Game {
        private Dictionnaire _dic;
        private int _score;

        public Dictionnaire Dic {
            get => _dic;
            set => _dic = value;
        }

        public int Score {
            get => _score;
            set => _score = value;
        }
    }

    public class Quinto {
        private Game _game;
        private Round _round;

        public Quinto(string dicPath) {
            Game = new Game {
                Dic = new Dictionnaire(dicPath),
                Score = 0
            };
        }

        public Game Game {
            get => _game;
            set => _game = value;
        }

        public Round Round {
            get => _round;
            set => _round = value;
        }

        public void NewRound() {
            Round = new Round();
            do {
                Round.Word = Game.Dic.ExtraireMot();
                Round.Word.Mot = NormalWord(Round.Word.Mot);
            } while (Round.Word.Mot.Contains(" ") || Round.Word.Mot.Length < 5 || Round.Word.Mot.Length > 25);
            Round.Tries = 0;
        }

        public string NormalWord(string word) {
            string formD = word.Normalize(NormalizationForm.FormD);
            StringBuilder canonicalWord = new StringBuilder();

            foreach (char character in formD) {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(character);

                if (uc != UnicodeCategory.NonSpacingMark) {
                    canonicalWord.Append(character);
                }
            }
            return (canonicalWord.ToString().Normalize(NormalizationForm.FormC).ToUpper());
        }
    }

    public class Round {
        private int _tries;
        private MotDictionnaire _word;

        public int Tries {
            get => _tries;
            set => _tries = value;
        }

        public MotDictionnaire Word {
            get => _word;
            set => _word = value;
        }
    }
}
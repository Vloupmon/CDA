using DictionnaireDLL;
using System.Timers;

namespace QuintoDLL {

    public class Quinto {
        private Dictionnaire _dic;
        private MotDictionnaire _word;
        private Timer _timer;

        public Quinto(string dicPath) {
            Timer = new Timer();
            Dic = new Dictionnaire(dicPath);

            do {
                Word = Dic.ExtraireMot();
            } while (Word.Mot.Contains(" "));
            Timer.Enabled = true;
        }

        public Dictionnaire Dic {
            get => _dic;
            set => _dic = value;
        }

        public MotDictionnaire Word {
            get => _word;
            set => _word = value;
        }

        public Timer Timer {
            get => _timer;
            set => _timer = value;
        }
    }
}
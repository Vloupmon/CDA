using System;
using DictionnaireDLL;
using System.Timers;

namespace QuintoDLL {

    public class Quinto {

        public void Timer() {
        }

        internal class Game {
            private uint _rounds;
            private uint _score;

            public uint Rounds {
                get => _rounds;
                set => _rounds = value;
            }

            public uint Score {
                get => _score;
                set => _score = value;
            }
        }

        internal class Round {
            private Timer _timer;
            private uint _tries;

            public Timer Timer {
                get => _timer;
                set => _timer = value;
            }

            public uint Tries {
                get => _tries;
                set => _tries = value;
            }
        }

        internal class Word : MotDictionnaire {

            public void CheckWord(string str) {
            }
        }
    }
}
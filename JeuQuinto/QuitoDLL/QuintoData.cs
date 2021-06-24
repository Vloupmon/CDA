using System.Timers;

namespace QuintoDLL {

    internal class QuintoData {

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

    internal class Word {
        private string _definition;
        private string _value;

        public string Definition {
            get => _definition;
            set => _definition = value;
        }

        public string Value {
            get => _value;
            set => _value = value;
        }
    }
}
}
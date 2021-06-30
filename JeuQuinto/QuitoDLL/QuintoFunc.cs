﻿using DictionnaireDLL;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace QuintoDLL {

    public enum States {
        Init = 0,
        Valid = 1,
        Fail = 2
    }

    public class Game {
        private Dictionnaire _dic;
        private int _score;
        private int _rounds;

        public Dictionnaire Dic {
            get => _dic;
            set => _dic = value;
        }

        public int Score {
            get => _score;
            set => _score = value;
        }

        public int Rounds {
            get => _rounds;
            set => _rounds = value;
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
            StringBuilder strb = new StringBuilder();
            do {
                Round.Word = Game.Dic.ExtraireMot();
                Round.Word.Mot = NormalWord(Round.Word.Mot);
            } while (Round.Word.Mot.Contains(" ") || Round.Word.Mot.Length < 5 || Round.Word.Mot.Length > 25);
            Round.Tries = 0;
            foreach (char c in Round.Word.Mot) {
                strb.Append('_');
            }
            Round.Mask = strb.ToString();
            Round.State = States.Init;
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
        private string _mask;
        private States _state;
        private int _tries;
        private MotDictionnaire _word;

        public event EventHandler StateChange;

        public event EventHandler ValidChar;

        public event EventHandler InvalidChar;

        public string Mask {
            get => _mask;
            set => _mask = value;
        }

        public int Tries {
            get => _tries;
            set => _tries = value;
        }

        public MotDictionnaire Word {
            get => _word;
            set => _word = value;
        }

        public States State {
            get => _state;
            set {
                _state = value;
                EventHandler handler = StateChange;
                handler?.Invoke(this, EventArgs.Empty);
            }
        }

        public void WordChecker(char c, Button sender = null) {
            if (Word.Mot.Contains(c.ToString())) {
                StringBuilder strb = new StringBuilder();
                for (int i = 0; i < Word.Mot.Length; i++) {
                    if (Word.Mot[i] == c) {
                        strb.Append(Word.Mot[i]);
                    } else {
                        strb.Append(Mask[i]);
                    }
                }
                if (sender != null) {
                    EventHandler handlerValid = ValidChar;
                    handlerValid?.Invoke(sender, EventArgs.Empty);
                }
                Mask = strb.ToString();
            } else if (sender != null) {
                Tries++;
                EventHandler handlerInvalid = InvalidChar;
                handlerInvalid?.Invoke(sender, EventArgs.Empty);
            }
        }

        public void StateCalc(object sender = null) {
            if (Tries == 9) {
                State = States.Fail;
            } else if (sender != null) {
                WordChecker((sender as Button).Text[0], (sender as Button));
                State = States.Init;
            }
            if (Mask == Word.Mot) {
                State = States.Valid;
            }
        }
    }
}
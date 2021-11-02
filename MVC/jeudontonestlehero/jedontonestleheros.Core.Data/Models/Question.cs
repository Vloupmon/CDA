using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jedontonestleheros.Core.Data {
    public class Question {
        private int _id;
        private int _number;
        private string _content;
        private string _answer;

        public int Id {
            get => _id;
            set => _id = value;
        }
        public int Number {
            get => _number;
            set => _number = value;
        }
        public string Content {
            get => _content;
            set => _content = value;
        }
        public string Answer {
            get => _answer;
            set => _answer = value;
        }

        public Question MyQuestion {
            get;
            set;
        }
    }
}

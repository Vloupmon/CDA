using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jedontonestleheros.Core.Data.Models {
    public class Answer {
        private int _id;
        private string _content;

        public int Id {
            get => _id;
            set => _id = value;
        }
        public string Content {
            get => _content;
            set => _content = value;
        }

        public List<Answer> MyAnswers {
            get;
            set;
        }
    }
}

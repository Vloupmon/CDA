using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jedontonestleheros.Core.Data {
    public class Paragraphe {
        private int _id;
        private int _number;
        private string _title;
        private string _description;

        public int Id {
            get => _id;
            set => _id = value;
        }
        public int Number {
            get => _number;
            set => _number = value;
        }
        public string Title {
            get => _title;
            set => _title = value;
        }
        public string Description {
            get => _description;
            set => _description = value;
        }
    }
}

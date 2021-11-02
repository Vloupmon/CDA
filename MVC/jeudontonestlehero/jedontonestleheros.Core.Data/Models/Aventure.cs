using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.Core.Data {
    public class Aventure {
        private int _id;
        private string _title;

        public string Title {
            get => _title;
            set => _title = value;
        }
        public int Id {
            get => _id;
            set => _id = value;
        }
    }
}

using System.Collections.Generic;

namespace jeudontonestleheros.Core.Data.Models {

    public class Response {
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

        public List<Response> Responses {
            get;
            set;
        }
    }
}
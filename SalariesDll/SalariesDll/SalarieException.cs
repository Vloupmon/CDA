using System;
using System.Runtime.Serialization;

namespace SalariesDll {

    [Serializable]
    internal class SalarieException : ApplicationException {
        private string _messageId;

        public string MessageId {
            get => _messageId;
            set => _messageId = value;
        }

        public SalarieException() : base() {
        }

        public SalarieException(string MessageId, string message) : base(message) {
            _messageId = MessageId;
        }

        public SalarieException(string MessageId, string message, Exception inner) : base(message, inner) {
            _messageId = MessageId;
        }

        protected SalarieException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
namespace TwitterClone.Domain.Entitities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _recieverId;
        private DateTime _sentAt;
        private string _content;

        public Message()
        {
            _id = Guid.NewGuid();
        } 

        public Guid Id
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid RecieverId
        {
            get { return _recieverId; }
        }

        public DateTime SentAt
        {
            get { return _sentAt; }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Content cannot be empty");
                }
                _content = value; 
            }
        }
    }
}
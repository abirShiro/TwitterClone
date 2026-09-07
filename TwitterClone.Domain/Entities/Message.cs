namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        private Guid _senderId;
        private Guid _recieverId;
        private string _content;

        public Message(Guid senderId, Guid recieverId, string content): base(Guid.NewGuid())
        {
            _senderId = senderId;
            _recieverId = recieverId;
            _content = content;
        } 

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid RecieverId
        {
            get { return _recieverId; }
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
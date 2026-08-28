namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _content;
        private DateTime _createdAt;
        private bool _isRead;

        public Notification()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
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

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }
    }
}
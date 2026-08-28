namespace TwitterClone.Domain.Entitities
{
    public class Tweet
    {
        public const int MaxLength = 280;
        private Guid _id;
        private Guid _authorId;
        private string _content;

        public Tweet()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
            set { if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Content cannot be empty");
                }
                if(value.Length > MaxLength)
                {
                    throw new ArgumentException("Content cannot exceed 280 characters");
                }
                _content = value;
            }
        }
    }
}
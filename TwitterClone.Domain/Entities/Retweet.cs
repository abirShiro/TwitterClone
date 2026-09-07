namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;

        public Retweet(Guid userId, Guid tweetId) : base (Guid.NewGuid())
        {
            _userId = userId;
            _tweetId = tweetId;
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

    
    }
}
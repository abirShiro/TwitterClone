namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {

        private Guid _tweetId;
        private Guid _userId;


        public Like(Guid tweetId, Guid userId): base(Guid.NewGuid())
        {
            _tweetId = tweetId;
            _userId = userId;
        } 

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }
    }
}
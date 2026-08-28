namespace TwitterClone.Domain.Entitities
{
    public class Follow
    {
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followDate;

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }

        public DateTime FollowDate
        {
            get { return _followDate; }
        }
    }
}
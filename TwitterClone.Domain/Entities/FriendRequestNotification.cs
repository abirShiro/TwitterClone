namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public Guid FriendRequestUserId {get; set;}

        public FriendRequestNotification(Guid friendRequestuserId): base("FriendRequest")
        {
            FriendRequestUserId = friendRequestuserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
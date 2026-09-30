namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikedByUserId { get; set; }

        public LikeNotification(Guid likedByUserId): base("Like")
        {
            LikedByUserId = likedByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string GetMessage()
        {
            return $"liked by user id {LikedByUserId}";
        }
        
    }
}
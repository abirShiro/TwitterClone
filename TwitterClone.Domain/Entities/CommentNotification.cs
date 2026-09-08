namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public Guid CommentedByUserId { get; set; }

        public CommentNotification(Guid commentedByUserId): base("Comment")
        {
            CommentedByUserId = commentedByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

    }
}
namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(): base("System")
        {
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string GetMessage()
        {
            return $"notification message {Message}";
        }
    }
}
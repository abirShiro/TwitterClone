namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        private string _username;
        private string _email;

        public User(string username, string email) : base(Guid.NewGuid())
        {
            _username = username;
            _email = email;
        }

        public string Username
        {
            get {return _username;}
            set{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username cannot be empty");
                }          
                _username = value;}         
        }

        public string Email
        {
            get {return _email;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be empty");
                } 
                _email = value; }
        }
    }
}
namespace TwitterClone.Domain.Entitities
{
    public class User
    {
        private Guid _id;
        private string _username;
        private string _email;

        public User()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get {return _id;}
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
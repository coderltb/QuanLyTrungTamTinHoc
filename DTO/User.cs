namespace DTO
{
    public class User
    {
        private int MaUser;

        public int _MaUser
        {
            get { return MaUser; }
            set { MaUser = value; }
        }

        private string Username;

        public string _UserName
        {
            get { return Username; }
            set { Username = value; }
        }

        private string Password;

        public string _Password
        {
            get { return Password; }
            set { Password = value; }
        }

        private string Email;

        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }

        private string SDT;

        public string _SDT
        {
            get { return SDT; }
            set { SDT = value; }
        }

        private bool IsAdmin;

        public bool _IsAdmin
        {
            get { return IsAdmin; }
            set { IsAdmin = value; }
        }
    }
}
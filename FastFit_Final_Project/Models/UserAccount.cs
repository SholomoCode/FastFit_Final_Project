namespace Fast_Fit_Final_Project.Model
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserAccount()
        {
        }

        public UserAccount(string u, string e, string p)
        {
            Username = u;
            Email = e;
            Password = p;
        }

    }
}

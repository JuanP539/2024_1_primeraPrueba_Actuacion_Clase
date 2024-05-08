namespace Models.Out
{
    public class UserLoginModelOut
    {
        public Guid Token { get; set; }
        public UserLoginModelOut() 
        {
            Token = Guid.NewGuid();
        }
        public UserLoginModelOut(Guid userToken)
        {
            Token = userToken;
        }
        public override bool Equals(object? obj)
        {
            return obj is UserLoginModelOut @out &&
                   Token.Equals(@out.Token);
        }
    }
}

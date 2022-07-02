namespace courseworkAD1.BusinessObjects
{
    public class CurrentUserBO
    {
        private string useridCurrentUser;
        private string emailCurrentUser;
        private string typeCurrentUser;

        public string UseridCurrentUser { get => useridCurrentUser; set => useridCurrentUser = value; }
        public string EmailCurrentUser { get => emailCurrentUser; set => emailCurrentUser = value; }
        public string TypeCurrentUser { get => typeCurrentUser; set => typeCurrentUser = value; }
    }
}

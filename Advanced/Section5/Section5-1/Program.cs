namespace Section501
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone();

            cp.CallPhone();
            cp.RecievePhone();

            cp.SendMail();
            cp.RecieveMail();

            cp.PlayGame();
            cp.BrowseWeb();
        }
    }
}
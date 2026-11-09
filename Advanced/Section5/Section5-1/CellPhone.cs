using System.Runtime.CompilerServices;

namespace Section501
{
    class CellPhone : IPhone, IMailer, IComputer
    {
        public void CallPhone()
        {
            Console.WriteLine("電話を掛ける");
        }

        public void RecievePhone()
        {
            Console.WriteLine("電話を受ける");
        }

        public void SendMail()
        {
            Console.WriteLine("メールを送る");
        }

        public void RecieveMail()
        {
            Console.WriteLine("メールを受信する");
        }

        public void PlayGame()
        {
            Console.WriteLine("ゲームをする");
        }

        public void BrowseWeb()
        {
            Console.WriteLine("ウェブを閲覧する");
        }
    }
}
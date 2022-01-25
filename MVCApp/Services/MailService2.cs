namespace MVCApp.Services
{
    public class MailService2 : IMailService
    {
        public bool Send(string from, string to, string message)
        {
            Console.WriteLine("MailService2 den mail gönderildi.");

            return true;
        }
    }
}

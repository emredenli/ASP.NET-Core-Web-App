namespace MVCApp.Services
{
    public class MailService : IMailService
    {
        public MailService()
        {
            
        }

        public bool Send(string from, string to, string message)
        {
            Console.WriteLine("MailService den mail gönderildi.");

            return true;
        }
    }
}

namespace MVCApp.Services
{
    public interface IMailService
    {
        bool Send(string from, string to, string message);
    }
}

using Portfolio.ViewModels;

namespace Portfolio.Helpers.Email
{
    public interface IEmailHelper
    {
        void SendMessage(EmailViewModel model);
    }
}

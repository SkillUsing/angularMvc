using System.Threading.Tasks;
using ElecSales.Services;
using Microsoft.AspNet.Identity;

namespace ElecSales.WebTools
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            SendCloundManager.Send(message.Destination, message.Subject, $"{message.Body}");
            return Task.FromResult(0);
        }
    }
}
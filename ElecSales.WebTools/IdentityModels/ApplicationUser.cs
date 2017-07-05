using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ElecSales.WebTools
{
    public class ApplicationUser : IdentityUser<int,IdentityUserLogin,IdentityUserRole,IdentityUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser,int> manager)
        {
            // ��ע�⣬authenticationType ������ CookieAuthenticationOptions.AuthenticationType �ж������Ӧ��ƥ��
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // �ڴ˴�����Զ����û�����
      
            return userIdentity;
        }
 
    }
}
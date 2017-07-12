using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using ElecSales.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace ElecSales.WebTools
{
    public class ProjectApiController : ApiController
    {
        public int UsrId => User.Identity.GetUserId<int>();

        protected async Task<bool> CreateAccount(CreateProjectViewModel model)
        {
            //todo 数据库重复验证
            var user = new ApplicationUser { UserName = model.UserName, Email = model.UserName };
            var result = await HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().CreateAsync(user, model.Pwd);
            return result.Succeeded;
        }
    }
}
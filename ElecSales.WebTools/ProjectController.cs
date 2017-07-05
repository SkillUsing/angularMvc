using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ElecSales.WebTools
{
    ///
    /// 摘要
    /// TODO 在这里加入Controller的共享代码
    /// 
    public class ProjectController : Controller
    {


        public int UserId => User.Identity.GetUserId<int>();
    }
}
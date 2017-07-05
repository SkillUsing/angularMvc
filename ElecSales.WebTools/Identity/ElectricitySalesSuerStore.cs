using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ElecSales.WebTools
{
    public class ElectricitySalesSuerStore: UserStore<ApplicationUser, IdentityRole, int, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        public ElectricitySalesSuerStore(DbContext context) : base(context)
        {
        }
        public override Task<IList<string>> GetRolesAsync(ApplicationUser user)
        {
            return Task.FromResult(new List<string>() as IList<string>);
        }
        protected virtual Task<ApplicationUser> GetUserAggregate(Expression<Func<ApplicationUser, bool>> filter)
        {
            return Task.FromResult(Users.FirstOrDefault(filter));
        }
    }
}

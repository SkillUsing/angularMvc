using Microsoft.AspNet.Identity;

namespace ElecSales.WebTools
{
    public class ApplicationUserValidator : UserValidator<ApplicationUser, int>
    {
        private ApplicationUserManager Manager { get; set; }
        public ApplicationUserValidator(ApplicationUserManager manager) : base(manager)
        {
            Manager = manager;
        }
    }
}

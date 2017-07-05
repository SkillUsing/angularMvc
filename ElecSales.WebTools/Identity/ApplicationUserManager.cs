using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace ElecSales.WebTools
{
    public class ApplicationUserManager : UserManager<ApplicationUser, int>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser, int> store) : base(store)
        {
        }
        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new ElectricitySalesSuerStore(context.Get<ApplicationDbContext>()));

            // �����û�������֤�߼�
            manager.UserValidator = new ApplicationUserValidator(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = false,
            };

            // �����������֤�߼�
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };
            manager.PasswordHasher = new NonPasswordHasher();


            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            //manager.RegisterTwoFactorProvider("�绰����", new PhoneNumberTokenProvider<ApplicationUser, int>
            //{
            //    MessageFormat = "���Ķ�����֤���ǣ� {0}��- -��"
            //});
            manager.RegisterTwoFactorProvider("�����ʼ�����", new EmailTokenProvider<ApplicationUser, int>
            {
                Subject = "mvcProject������֤",
                BodyFormat = "��������ȷ�������˻���{0}"
            });
            manager.EmailService = new EmailService();
            //manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser, int>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }


    }

}
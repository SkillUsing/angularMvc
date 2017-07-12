using System;

namespace ElecSales.Models
{
    public class AccountsViewModel
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }
    }

    public class CreateProjectViewModel
    {
        public string UserName { get; set; }

        public string Pwd { get; set; }

        public string Pwds { get; set; }

        public string ProjectTitle { get; set; }

        public int Price { get; set; } = 0;
    }
}
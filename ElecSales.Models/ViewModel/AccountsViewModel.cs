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
}
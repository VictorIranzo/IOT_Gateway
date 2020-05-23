using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Billing.Persistence
{
    public class Client
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string IBAN { get; set; }

        public string BankingEntity { get; set; }
    }
}
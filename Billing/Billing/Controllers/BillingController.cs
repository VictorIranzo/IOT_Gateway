namespace Billing.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [Route("Bills")]
    public class BillingController : Controller
    {
        private readonly Context context;

        public BillingController(Context context)
        {
            this.context = context;
        }

        [HttpGet("Get")]
        public IEnumerable<Bill> GetBills()
        {
            return this.context.Bills.ToList();
        }
    }
}
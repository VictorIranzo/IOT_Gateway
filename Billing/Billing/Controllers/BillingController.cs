namespace Billing.Controllers
{
    using Billing.Persistence;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [Route("Bills")]
    public class BillingController : ControllerBase
    {
        private readonly Context context;

        public BillingController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bill>> GetBills()
        {
            return this.context.Bills.ToList();
        }
    }
}
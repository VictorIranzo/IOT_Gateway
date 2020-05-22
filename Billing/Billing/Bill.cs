namespace Billing
{
    using System;

    public class Bill
    {
        public Guid Id { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }
    }
}
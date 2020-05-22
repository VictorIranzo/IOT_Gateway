namespace HealthAndWelfare.Persistence
{
    using System;

    public class Treatment
    {
        public Guid Id { get; set; }

        public Guid BillId { get; set; }

        public string Description { get; set; }
    }
}
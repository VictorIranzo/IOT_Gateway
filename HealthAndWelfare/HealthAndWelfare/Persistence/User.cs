namespace HealthAndWelfare.Persistence
{
    using System;

    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime BirthDay { get; set; }

        public bool IsVaccinated { get; set; }
    }
}
namespace SMEasy.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactsManagerDbContext >
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

      
    }
}

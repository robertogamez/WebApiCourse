namespace CountingKs.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CountingKs.Data.CountingKsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CountingKs.Data.CountingKsContext context)
        {
            // Seed the database if necessary
            //new CountingKsSeeder(context).Seed();
        }
    }
}

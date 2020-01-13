namespace ExecStatusApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ExecStatusApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ExecStatusApp.Data.ExecStatusAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExecStatusApp.Data.ExecStatusAppContext context)
        {
            context.ExecStats.AddOrUpdate(x => x.Id,
                new ExecStats()
                {
                    Id = DateTime.Now,
                    AppName = "test",
                    prop1 = 1,
                    prop2 = 2,
                    prop3 = 3,
                    SourceMachine = "testsource",
                    Status = 0,
                    Task = "startdb"
                }
                );
        }
    }
}

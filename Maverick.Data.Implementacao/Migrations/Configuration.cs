namespace Maverick.Data.Implementacao.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Maverick.Entidades;
    using Maverick.Data.Implementacao.Contexto;
    internal sealed class Configuration : DbMigrationsConfiguration<Maverick.Data.Implementacao.Contexto.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Maverick.Data.Implementacao.Contexto.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            /*context.Cliente.AddOrUpdate(c => c.IdCliente, 
                new Cliente() { IdCliente = 1, Nome = "Luiz Guilherme Bandeira", Email = "arkanael@gmail.com", DataCadastro = DateTime.Now },
                new Cliente() { IdCliente = 2, Nome = "Bill Gates", Email= "bgates@hotmail.com", DataCadastro = DateTime.Now }
                );
            */

        }
    }
}

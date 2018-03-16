using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using Maverick.Entidades;
using Maverick.Data.Implementacao.Mapeamentos;

namespace Maverick.Data.Implementacao.Contexto
{
    //Herdar o DbContext
    public class DataContext : DbContext
    {
        //Contrutor que envie para o DbContext a connectionstrings pelo contrutor da super classe
        public DataContext():base(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString)
        {

        }

        //Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
        }

        //Declarar um DsSet para cada entidade
        public DbSet<Cliente> Cliente { get; set; }

    }
}

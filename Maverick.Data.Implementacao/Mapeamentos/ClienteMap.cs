using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Maverick.Entidades;

namespace Maverick.Data.Implementacao.Mapeamentos
{
    /// <summary>
    /// Classe de mapeamento tipada para a entidade Cliente.
    /// </summary>
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            
            ToTable("Cliente");
            HasKey(c => c.IdCliente);

            Property(c => c.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired();

            Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.DataCadastro)
                .HasColumnType("Date")
                .IsRequired();

        }
    }
}

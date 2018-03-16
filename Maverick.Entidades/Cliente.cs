using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Entidades
{
    public class Cliente
    {
        public virtual int IdCliente { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataCadastro { get; set; }
    }
}

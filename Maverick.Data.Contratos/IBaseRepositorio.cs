using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Data.Contratos
{
    public interface IBaseRepositorio<TEntiy> : IDisposable where TEntiy : class
    {
        void Insert(TEntiy obj);

        void Update(TEntiy obj);

        void Delete(TEntiy obj);

        List<TEntiy> FindAll();

        TEntiy FindById(int id);
    }
}

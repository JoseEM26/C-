using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenT2.DAO
{
    internal interface Dao<T>
    {
        List<T> SeleccionarTodo();
        T SeleccionarXID(int id);
        void Update(T t);
        void Delete(int id);
        void Create(T t);
    }
}

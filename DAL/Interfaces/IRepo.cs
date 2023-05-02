using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<Type, ID, RET>
    {
        RET Create(Type obj);

        List<Type> Read();

        Type Read(ID id);

        RET Update(Type obj);

        bool Delete(ID id);
    }
}

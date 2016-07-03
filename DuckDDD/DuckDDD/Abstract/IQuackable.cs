using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD.Abstract
{
    public interface IQuackable : IBehaviour
    {
        void Quack();
    }
}

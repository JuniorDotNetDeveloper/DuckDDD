using DuckDDD.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD.BehaveourRule
{
    public class NoSwimm : ISwimmable
    {
        public BehaviourType BehaviourType
        {
            get { return BehaviourType.Swimmable; }
        }
        public void Swimm()
        {
            Console.WriteLine("Can't swimm");
        }
    }
}

using DuckDDD.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD.BehaveourRule
{
    public class NoFly : IFlyable
    {
        public BehaviourType BehaviourType
        {
            get { return BehaviourType.Flyable; }
        }

        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}

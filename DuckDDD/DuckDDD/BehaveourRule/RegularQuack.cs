using DuckDDD.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD.BehaveourRule
{

    public class RegularQuack : IQuackable
    {
        public BehaviourType BehaviourType
        {
            get { return BehaviourType.Quackable; }
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}

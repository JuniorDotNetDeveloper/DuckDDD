using DuckDDD.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD.BehaveourRule
{
    public class RegularFly : IFlyable
    {
        private int distance;

        public BehaviourType BehaviourType
        {
            get { return BehaviourType.Flyable; }
        }

        public RegularFly(int distance)
        {
            this.distance = distance;
        }

        public void Fly()
        {
            Console.WriteLine("Can Fly only {0} metters", distance);
        }
        
    }
}

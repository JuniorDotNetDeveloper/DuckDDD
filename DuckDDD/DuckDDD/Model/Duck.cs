using DuckDDD.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD.Model
{
    class Duck
    {
        private IEnumerable<IBehaviour> behaviours;


        public Duck(IEnumerable<IBehaviour> behaviours)
        {
            this.behaviours = behaviours;
        }

        public void Quack()
        {
            ((IQuackable)behaviours.Single(d => d.BehaviourType == BehaviourType.Quackable)).Quack();
        }

        public void Fly()
        {
            ((IFlyable)behaviours.Single(d => d.BehaviourType == BehaviourType.Flyable)).Fly();
        }
        public void Swimm()
        {
            ((ISwimmable)behaviours.Single(d => d.BehaviourType == BehaviourType.Swimmable)).Swimm();
        }
    }
}

using DuckDDD.Abstract;
using DuckDDD.BehaveourRule;
using DuckDDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck regularDuck = new Duck(new List<IBehaviour> { new RegularFly(100), new NoQuack(), new RegularSwim() });

            regularDuck.Quack();
            regularDuck.Swimm();
            regularDuck.Fly();

            Console.ReadLine();
        }
    }
}

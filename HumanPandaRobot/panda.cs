using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public class Panda : Pet, ICanSleep, ICanEat
    {
        public void WakeUp()
        {
            this.IsAsleep = false;
        }
        public void FallAsleep()
        {
            this.IsAsleep = true;
        }
        public void Eat(string food)
        {
            Console.WriteLine("Panda is eating {0}", food);
        }
        public override void SayHello()
        {
            Console.WriteLine("mmmmmmm");
        }
        public override string ToString()
        {
            return string.Format("name: {0}, birthday: {1}, IsAsleep: {2}, OWnerNAme: {3}", this.Name, this.Birthday, IsAsleep, OwnerName);
        }
    }
}

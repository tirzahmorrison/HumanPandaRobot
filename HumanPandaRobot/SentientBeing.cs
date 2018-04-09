using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public abstract class SentientBeing
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        protected bool IsAsleep { get; set; }
        public virtual void SayHello()
        {
            Console.WriteLine("'Sup?");
        }
    }
}

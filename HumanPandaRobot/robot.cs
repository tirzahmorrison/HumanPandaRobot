using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public class Robot : Pet
    {
        public string VersionNumber { get; set; }
        public void StartUp()
        {
            this.IsAsleep = false;
        }
        public void ShutDown()
        {
            this.IsAsleep = true;
        }
        public override void SayHello()
        {
            Console.WriteLine("Bee-boop");
        }
        public override string ToString()
        {
            return string.Format("name: {0}, birthday: {1}, IsAsleep: {2}, VersionNumber: {3}", this.Name, this.Birthday, IsAsleep, VersionNumber);
        }
    }
}

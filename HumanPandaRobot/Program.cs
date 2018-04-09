using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    class Program 
    {
        static void Main(string[] args)
        {
            var human = new Human();
            human.Name = "name";
            human.Birthday = DateTime.Parse("2008-05-01");
            human.FallAsleep();
            human.WakeUp();
            human.Eat("zombies");
            human.SayHello();
            var panda = new Panda();
            panda.Name = "name";
            panda.Birthday = DateTime.Parse("2007-05-01");
            panda.FallAsleep();
            panda.WakeUp();
            panda.Eat("people");
            panda.SayHello();
            var robot = new Robot();
            robot.Name = "name";
            robot.Birthday = DateTime.Parse("2017-05-01");
            robot.VersionNumber = "1.0.1";
            robot.StartUp();
            robot.ShutDown();
            robot.SayHello();
            human.Adopt(panda);
            human.Adopt(robot);
            var beings = new List<SentientBeing>();
            beings.Add(human);
            beings.Add(panda);
            beings.Add(robot);
            foreach (var being in beings)
            {
                Console.WriteLine(being.ToString());
            }
            Console.ReadLine();
        }
    }
}

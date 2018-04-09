using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanPandaRobot
{
    public class Human : SentientBeing, ICanSleep, ICanEat
    {
        private List<Pet> pets = new List<Pet>();
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
            Console.WriteLine("Human is eating {0}", food);
        }
        public void Adopt(Pet pet)
        {
            this.pets.Add(pet);
            pet.OwnerName = this.Name;
        }
        public override string ToString()
        {
            return string.Format("name: {0}, birthday: {1}, IsAsleep: {2}, pets: {3}", this.Name, this.Birthday, IsAsleep, String.Join(",",pets));
        }
    }
}

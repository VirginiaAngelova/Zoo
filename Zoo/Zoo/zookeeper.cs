using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public sealed class zookeeper
    {
        public string name;
        public zookeeper(string Fname)
        {
            this.name = Fname;
        }
       
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
      
        public static void FeedAnimals(List<Animal>animals)
        {

            foreach (var animal in animals)
            { 
                Random rnd = new Random();
                int kg = rnd.Next(0, 20);

                animal.Eat(kg);
            }
            
        }
    }
}

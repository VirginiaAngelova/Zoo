using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
   public class Bear : Animal
    {
        public Bear(string name, int cageNum) : base(name, cageNum)
        {

        }

        public override void Eat(int kg)
        { 

            if (kg >= 2 && kg <= 5)
            {
                Console.WriteLine("The bear is eating:" + kg);
            }
            else
            {
                Console.WriteLine("This kg is too much or less to feed the bear!");
            }
        }

        
    }
}

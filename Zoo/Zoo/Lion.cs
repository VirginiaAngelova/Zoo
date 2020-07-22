using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Lion : Animal
    {

        public Lion(string name, int cageNum) : base(name, cageNum)
        {
          
        }

        public override void Eat(int kg)
        {
            if (kg > 0 && kg < 10)
            {
                Console.WriteLine("The Lion is eating:" + kg);
            }
            else
            {
                Console.WriteLine("This kg is too much or less to feed the lion!");
            }
        }

      
    }
}

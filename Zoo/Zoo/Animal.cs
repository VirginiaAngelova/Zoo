using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        public string animalName = null;
        public int cageNumber ;
        private string v1;
        private int v2;

        public Animal( string name,int cageNum)
        {
            this.animalName = name;
            this.cageNumber = cageNum;
        }

        protected Animal(string v1, string name, int v2, int cageNum)
        {
            this.v1 = v1;
            this.name = name;
            this.v2 = v2;
            this.cageNum = cageNum;
        }

        public string name
        {
            get
            {
                return name;
            }
            set
            {
                if (this.name != null)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                }
                
            }
        }

        public int cageNum
        {
            get
            {
                return cageNum;
            }
            set
            {
                if (this.cageNum > 0)
                {
                    this.cageNum = value;
                }
                else
                {
                    Console.WriteLine("The cage number is invalid");
                }
            }
        }
        public abstract void Eat(int food);
          
    }
}

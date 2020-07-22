using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion Lion1 = new Lion("Pesho", 6);
            Lion Lion2 = new Lion("Nikola", 2);

            Bear Bear1 = new  Bear("Lili", 4);
            Bear Bear2 = new Bear("Stefi", 3);

/*
            Lion1.Eat(6);
            Lion2.Eat(4);
            Bear1.Eat(2);
            Bear2.Eat(3);
*/

            zookeeper zookeeper1 = new zookeeper("Ivan");
           
            List<Animal> animals = new List<Animal>();
            {
                animals.Add(Lion1);
                animals.Add(Lion2);
                animals.Add(Bear1);
                animals.Add(Bear2);

            };
            zookeeper.FeedAnimals(animals);

        }
    }
}


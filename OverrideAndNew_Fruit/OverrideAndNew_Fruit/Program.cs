using System;

namespace OverrideAndNew_Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(.5); // invoking directly on the derived class
            apple.GetCost();
            Fruit fruit = apple; // invoking on derived class cast as base class
            fruit.GetCost();
        }
    }
    class Fruit // base class
    {
        public double Cost { get; protected set; }
        public virtual void GetCost()
        {
            Console.WriteLine("Getting Cost of fruit");
        }
    }
    class Apple : Fruit // derived class
    {
        public Apple(double c)
        {
            Cost = c;
        }
        public new void GetCost() // Override keyword shows Fruit class but not Apple class output
            // the New keyword shows both classes their output from the Console.Wr. methode
        {
            Console.WriteLine("Apples are ${0} a dozen", Cost * 12);
        }
    }
}

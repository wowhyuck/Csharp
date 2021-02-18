using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        abstract class Monster
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            FlyableOrc orc = new FlyableOrc();
            DoFly(orc);
        }
    }
}

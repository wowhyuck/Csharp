using System;

namespace OOP
{
    // 객체(OOP: Object Oriented Programming)

    // Knight
    // 속성: hp, attack
    // 기능: Move, Attack, Die

    // Ref 참조
    class Knight
    {
        // 필드
        static public int counter = 1;        // 오로지 1개만 존재!

        public int id;
        public int hp;
        public int attack;

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        static public void Test()
        {
            counter++;
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();      // static
            knight.Move();                              // 일반

            Console.WriteLine();

            Random rand = new Random();
            rand.Next(0, 2);
        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    // 객체(OOP: Object Oriented Programming)
    // 은닉성/상속성/다향성
    // Ref 참조

    class Player        // 부모 or 기반 클래스
    {
        // 필드
        static public int counter = 1;        // 오로지 1개만 존재!

        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
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

    class Knight : Player        // 자식 or 파생 클래스
    {
        int c;

        public Knight() : base(100)
        {
            this.c = 10;
            base.hp = 100;
            Console.WriteLine("Knight 생성자 호츨!");
        }
    }

    class Mage : Player       
    {

    }

    class Archer : Player
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
        }
    }
}

using System;
using System.Linq;
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

        protected int id;
        protected int hp;
        protected int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
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

        // overloading(함수 이름의 재사용)
        // override(다형성에서 사용되는 문법, 어떤 함수에다가 실제 타입에 따라 작동)
        public sealed override void Move()
        {
            base.Move();
            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        //public override void Move()
        //{
        //    Console.WriteLine("SuperKnight 이동!");
        //}
    }

    class Mage : Player       
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class Archer : Player
    {

    }

    class Program
    {
        static void EnterGame(Player player)
        {
            //bool isMage = (player is Mage);
            //if(isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}

            player.Move();

            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }

        }

        static void Main(string[] args)
        {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('P');

            // 2. 변형
            name = name + " Junior";

            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();

            string newName = name.Replace('r', 'l');

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);
        }
    }
}

using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            protected int hp;

            //public int Hp
            //{
            //    get { return hp; }
            //    private set { hp = value; }
            //}

            public int Hp
            {
                get; set;
            }

            // ==
            //private int _hp;
            //public int GetHp() { return _hp; }
            //public void SetHp(int value) { _hp = value; }

            public int GetHp() { return hp; }               // Getter, Get 함수
            public void SetHp(int hp) { this.hp = hp; }     // Setter, Set 함수
        }

        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            knight.SetHp(100);

            knight.Hp = 100;

            int hp = knight.Hp;
        }
    }
}

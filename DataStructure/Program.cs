using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataStructure
{
    class Program
    {
        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }

        static void Main(string[] args)
        {
            // Nullable -> Null + able
            int? number = null;
            number = 3;
            int a;

            if (number != null)
            {
                a = number.Value;
                Console.WriteLine(a);
            }

            if(number.HasValue)
            {
                a = number.Value;
                Console.WriteLine(a);
            }

            // ==
            int b = number ?? 0;        // number가 null이 아니면 가지고 있는 value 대입, null이면 0으로 초기화
            Console.WriteLine(b);

            /* --------------------------------------------- */

            Monster monster = null;

            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            // ==
            int? id = monster?.Id;      // Nullable -> 형식?, null이면 null로 반환, null이 아니면 해당 값 반환
        }
    }
}

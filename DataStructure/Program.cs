using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Monster
    {
        public int id;

        public Monster(int id) { this.id = id; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            // HashTable
            // 메모리 손해
            // [메모리를 내주고, 성능을 취한다]

            // Key -> Value
            // Dictionary
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for(int i=0; i<10000; i++)
            {
                dic.Add(i, new Monster(i));
            }
            
            Monster mon;
            bool found = dic.TryGetValue(20000, out mon);

            dic.Remove(7777);
            dic.Clear();
        }
    }
}

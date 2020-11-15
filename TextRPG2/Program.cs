using System;

namespace TextRPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Knight();
            Player player2 = new Archer();
            Monster monster = new Orc();

            int damage = player.getAttack();
            player2.onDamaged(damage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3,
    }

    class Player
    {
        protected PlayerType type = PlayerType.None;
        protected int hp = 0;
        protected int attack = 0;

        protected Player(PlayerType type)
        {
            this.type = type;
        }

        public void setInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public PlayerType getPlayerType() { return type; }
        public int getHp() { return hp; }
        public int getAttack() { return attack; }

        public bool isDead() { return hp <= 0; }

        public void onDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            setInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            setInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            setInfo(50, 15);
        }
    }
}

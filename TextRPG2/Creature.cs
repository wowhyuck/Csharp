using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG2
{
    public enum CreatureType
    {
        None = 0,
        Player = 1,
        Monster = 2,
    }

    class Creature
    {
        CreatureType type;
        protected int hp = 0;
        protected int attack = 0;

        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        public void setInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }


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
}

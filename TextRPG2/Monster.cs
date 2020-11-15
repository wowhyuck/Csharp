using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG2
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3,
    }

    class Monster : Creature
    {
        protected MonsterType type = MonsterType.None;

        public Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType getMonsterType() { return type; }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            setInfo(10, 1);
        }
    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            setInfo(20, 1);
        }
    }

    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            setInfo(15, 5);
        }
    }
}

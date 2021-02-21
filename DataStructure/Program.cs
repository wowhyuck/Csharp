using System;
using System.Collections.Generic;

namespace DataStructure
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate Return MyFunc<Return>();
        delegate Return MyFunc<T, Return>(T item);
        delegate Return MyFunc<T1, T2, Return>(T1 t1, T2 t2);
        // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재한다.
        // -> 반환 타입이 있을 경우 Func
        // -> 반환 타입이 없을 경우 Action

        static Item FindItem(Func<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            Func<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };
            Item item = FindItem(selector);

            // Lambda : 일회용 함수를 만드는데 사용하는 문법
            //Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            // Anonymous Function : 무명 함수 / 익명 함수
            //Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });
        }
    }
}

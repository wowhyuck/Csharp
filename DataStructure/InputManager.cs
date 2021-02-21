using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    // Observer Pattern
    class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();

            if(info.Key == ConsoleKey.A)
            {
                // 모두한테 알려준다
                InputKey();
            }
        }
    }
}

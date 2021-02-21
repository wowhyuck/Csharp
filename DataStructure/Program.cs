using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }

        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while(true)
            {
                inputManager.Update();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rl = new RandomList();
            rl.Add("ggg");
            rl.Add("ttt");
            rl.RandomString();
            rl.RandomString();
          

            rl.RemoveRandomElement();

            foreach (var element in rl)
            {
                Console.WriteLine(element);
            }
        }
    }
}

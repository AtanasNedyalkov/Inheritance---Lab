using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList:List<string>
    {
        private Random rnd { get; set; }
        public RandomList(Random rnd)
        {
            this.rnd = rnd;
        }
        public RandomList()
        {
        }
        public string RemoveRandomElement()
        {
            string str = string.Empty;
            int index = rnd.Next(0, this.Count);
            str = this[index];
            this.RemoveAt(index);
            return str;
        }
        public int RandomInteger()
        {
            return this.rnd.Next(0,int.MaxValue);
        }
        public int RandomString() => this.RandomInteger();
    }
}

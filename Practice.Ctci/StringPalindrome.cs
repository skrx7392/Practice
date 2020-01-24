using System;
using System.Collections.Generic;

namespace Practice.Ctci
{
    public class StringPalindrome
    {
        public bool checkPalindrome(string inputString) {
            var map = new Dictionary<char, int>();
            foreach(var character in inputString) {
                if(map.ContainsKey(character))
                    map.Remove(character);
                else
                    map.Add(character, 1);
            }
            if(map.Keys.Count > 1)
                return false;
            return true;
        }
    }
}

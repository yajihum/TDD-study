﻿namespace TDDStudy
{
    public class Pair
    {
        public string from;
        public string to;
        
        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public bool CheckIsEqual(object obj)
        {
            Pair pair = (Pair)obj;
            return from.Equals(pair.from) && to.Equals(pair.to);
        }

        public int HashCode()
        {
            return 0;
        }
    }
}

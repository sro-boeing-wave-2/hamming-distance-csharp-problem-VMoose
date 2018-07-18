using System;
using System.Linq;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            if(current == null)
                throw new ArgumentNullException("current");
            else if(original == null)
                throw new ArgumentNullException("original");
            else if (original.Length != current.Length)
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            else
            for (int i = 0, length = original.Length; i < length; i++)
            {
                if (original[i] != current[i])
                    hammingDistance++;
            }
            return hammingDistance;
        }
    }
}

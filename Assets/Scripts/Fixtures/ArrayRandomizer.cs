using UnityEngine;

namespace Quiz
{
    public class ArrayRandomizer
    {
        public static T GetValue<T>(T[] t)
        {
            int index = Random.Range(0, t.Length);
            return t[index];
        }
    }
} 

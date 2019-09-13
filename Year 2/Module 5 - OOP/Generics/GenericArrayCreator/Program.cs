using System;

namespace GenericArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = ArrayCreator.create(5, "A");
        }
    }
    
    public static class ArrayCreator
    {
        public static T[] create<T>(int lenght, T item)
        {
            var arr = new T[lenght]; 
            return arr;
        }
    }
}

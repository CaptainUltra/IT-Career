using System;

namespace GenericArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = ArrayCreaator.create(5, "A");
        }
    }
    
    public static class ArrayCreaator
    {
        public static T[] create(int lenght, T item)
        {
            return new T[lenght]; 
        }
    }
}

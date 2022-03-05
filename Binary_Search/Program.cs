using System;

namespace Binary_Search
{
    class Program
    {
        public static object Binarysearch_Object_Methods(int[] array, int number, int start, int end)
        {
            int mid = (start + end) / 2;
            if (start > end)
                return null;
            else
            {
                if (number == array[mid])
                    return ++mid;
                else if (number < array[mid])
                    return Binarysearch_Object_Methods(array, number, start, end - 1);
                else
                    return Binarysearch_Object_Methods(array, number, start + 1, end);
            }
        }
        public static bool Binarysearch_Boolean_Methods(int[] array, int number, int start, int end)
        {
            int mid = (start + end) / 2;
            if (start > end)
                return false;
            else
            {
                if (number == array[mid])
                {
                    mid += 1;
                    return true;
                }
                else if (number < array[mid])
                    return Binarysearch_Boolean_Methods(array, number, start, end - 1);
                else
                    return Binarysearch_Boolean_Methods(array, number, start + 1, end);
            }

        }
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[] { 12, 10, 56, 77, 78, 100, 1, 0, 2, 14, 8 };
                int user_number;
                int end = array.Length;
                Array.Sort(array);
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");
                Console.WriteLine();

                Console.Write("Pleas Enter Your Number:"+"\t");
                user_number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (Binarysearch_Boolean_Methods(array, user_number, 0, end))
                    Console.WriteLine("Found it in boolean methods");
                else
                    Console.WriteLine("Not found it in boolean methods ");
                Console.WriteLine();
                if (Binarysearch_Object_Methods(array, user_number, 0, end) == null)
                    Console.WriteLine("Not found it in obj methods ");
                else
                    Console.WriteLine($"Found it in obj methods address:{Binarysearch_Object_Methods(array, user_number, 0, end)}");
            }
            catch
            {
                Console.WriteLine("Error !");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

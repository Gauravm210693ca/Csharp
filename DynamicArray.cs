using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
   
        public class DynamicArray<T>
        {
            private T[] array;
            private int capacity;
            private int count;
            public DynamicArray(int initialSize)
            { 

                array = new T[initialSize];
                capacity = initialSize;
                count = 0;
            }
            public int Count
            {
                get { return count; }
            }
            public void Add(int index, T item)
            {
                if (count == capacity)
                {
                    ResizeArray();
                }
                array[index] = item;
                count++;
            }
            private void ResizeArray()
            {
                capacity *= 2;
                T[] newArray = new T[capacity];
                Array.Copy(array, newArray, count);
                array = newArray;
            }

            public T this[int index]
            {
                get
                {
                    return array[index];
                }
            }
        }
    public class Program { 
        static void Main(string[] args)
        {
            DynamicArray<int> numbers = new DynamicArray<int>(2);
            numbers.Add(0, 100);
            numbers.Add(1, 200);
            numbers.Add(2, 300);
            numbers.Add(3, 400);
            int value = numbers[2];
            System.Console.WriteLine($"Total Number Of Items in Array:{numbers.Count} ,Value:{value} at index:2");

            DynamicArray<string> stringItems = new DynamicArray<string>(2);
            stringItems.Add(0, "100");
            stringItems.Add(1, "200");
            stringItems.Add(2, "300");
            stringItems.Add(3, "400");
            string itemValue = stringItems[3];
            System.Console.WriteLine($"Total Number Of Items in Array:{stringItems.Count} , Value:{itemValue} at index:3");
        }
    }
}

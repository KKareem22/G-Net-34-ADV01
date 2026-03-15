using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes
{
    internal class Calculate <T> where T:IComparable<T>
    {
        public static T Add<T>(T num1,T num2) where T :INumber<T>
        {
            return num1 + num2;
        }
        public static T Subtraction<T>(T num1,T num2) where T :INumber<T>
        {
            return num1 - num2;
        }
        public static void BubbleSort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                 
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }

    }
}

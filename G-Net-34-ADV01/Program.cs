using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_Net_34_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //What is a generic class? Why use generics?
            //Generic Class:uses type parameters that are replaced with actual types when you create an instance. The type parameter T acts as a placeholder.
            //Why use :
            //1)IntelliSense.
            //2)Code Reuse.
            //3)Performance
            //4)Type Safety
            #endregion
            #region Q02
            //: Write a generic class Container<T> with Add and Get methods?


            //Container<int> container = new();
            //container.Add(1);
            //container.Add(2);
            //container.Add(3);
            //foreach (var item in container.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q03
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>?
            //Multiple Type Parameters in Generics mean that a class, method, interface, or delegate can use more than one generic type instead of a single type.
            //They allow the code to work with multiple data types at the same time.


            //Pair<int, string> pair01 = new(55,"Kareem");
            //Console.WriteLine($"Pair01 -> {pair01}");

            #endregion
            #region Q04
            //Q4: What is a generic method? Write Swap<T> method.
            //A generic method declares its own type parameter(s). It can exist in both generic and non-generic classes. The compiler often infers the type argument.

            //int x = 5, y = 15;
            //Console.WriteLine($"Before Swapping ::x={x},y={y}");
            //Swap(ref x, ref y);
            //Console.WriteLine($"After Swapping ::x={x},y={y}");

            //Console.WriteLine(new string('*',50));
            ////other example with string
            //string name1 = "Kareem", name2 = "Rawan";
            //Console.WriteLine($"Before Swapping ::name1={name1},name2={name2}");
            //Swap(ref name1, ref name2);
            //Console.WriteLine($"After Swapping ::name1={name1},name2={name2}");

            #endregion


        }
        #region Swap Function
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

        }
        #endregion
    }
}

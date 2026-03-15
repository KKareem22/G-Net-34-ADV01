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

        }
    }
}

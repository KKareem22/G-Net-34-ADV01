using G_Net_34_ADV01.Classes;
using G_Net_34_ADV01.Classes.Q09;
using G_Net_34_ADV01.Classes.Q11;
using G_Net_34_ADV01.Classes.Q12;
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
            #region Q05
            //Q5: Write a generic method FindMax<T> that finds maximum value?


            //int[] numbers = [5, 9, 4, 11, 3, 7];
            //Console.WriteLine($"The Max Number in Array is ={Max(numbers,numbers.Length)}");
            #endregion
            #region Q06
            //Q6: What is a generic interface? Write IRepository<T>?
            //Generic interfaces define contracts with type parameters. Classes implementing them specify the actual types.

            #endregion
            #region Q07
            //Q7: What is the 'struct' constraint? Write an exampl?
            //where T : struct restricts T to value types only. Useful when you need value semantics (copy, no null).


            //Q07<int> q = new();
            //q.DisplaySum(8, 9);
            #endregion
            #region Q08
            //Q8: What is the 'class' constraint? Write an example.
            //where T : class restricts T to reference types only. This allows T to be null and enables reference comparison.


            //Cache<string> cacheString = new();
            //Console.WriteLine($"Is Null :{cacheString.ISNull()}");
            //cacheString.SetCache("Kareem");
            //Console.WriteLine(new string('_',20)+"After Set value"+new string('_',20));
            //Console.WriteLine($"Is Null  :{cacheString.ISNull()}");
            #endregion
            #region Q09
            //Q9: What is the 'new()' constraint? Write an example.
            //where T : new() requires T to have a public parameterless constructor. This allows you to create instances of T inside the generic code.


            //Factory<ClsUser> factory = new();
            //var Users = factory.CreateMany(3);
            //foreach (var user in Users)
            //{
            //    Console.WriteLine(user);
            //}

            #endregion
            #region Q10
            //Q10:  What is the interface constraint? Write an example.
            //where T : IInterface requires T to implement a specific interface. This enables calling interface methods on type parameter.

            //Console.WriteLine($"5.7+4= {Calculate<double>.Add(5.7,4)}");

            #endregion
            #region Q11
            //Q11: What is the base class constraint? Write an example.
            //It is a rule that specifies that the generic type argument (T) must be the specified base class or inherit from it. This allows the code to safely access all members (properties and methods) of that base class.

            //Correct exmaple

            //var HR = new HR_System();
            //var engineer=new Engineer();
            //engineer.Name = "Kareem";
            //HR.ProcessEmployee(engineer);//استخدام Engineer (صح - لأنه وارث من Employee)

            //////wrong example
            ///
            ////var robot = new Robot();
            ////robot.Name = "Robot1";
            ////HR.ProcessEmployee(robot);//Compile Error

            #endregion
            #region Q12
            //How do you apply multiple constraints? Write an example.
            /*
             * You can combine multiple constraints for a single type parameter, and have different constraints for different type parameters.
             * Order matters: class/struct first, then interfaces, then new() last!
             */

            //Container2 c = new();
            //var book= new Book() { Title="Clean Code"};
            //Console.WriteLine(c.CreateEmpty<Book>());
            #endregion
            #region Q13
            //Q13: What does the 'default' keyword do in generics?
            //answer:
            //default(T) or default returns the default value for type T: null for reference types, 0/false for value types.
            // Use default when you need to initialize or return a "zero" value without knowing the type.

            #endregion
            #region Q14
            //Q14: Write a SafeList<T> that returns default when the index is invalid.


            ////1)Example with array of intger
            //int[] numbers = [5, 10, 15];
            //SafeList<int> nums = new SafeList<int>(numbers);
            //Console.WriteLine($"Element of index [1] :{nums.GetItem(1)}");
            //Console.WriteLine($"Element of index [5] :{nums.GetItem(5)}");

            ////2)Example with array of string
            //Console.WriteLine(new string('*',40));
            //string[] names = ["Kareem", "Rawan", "Rana"];
            //SafeList<string> Listnames = new SafeList<string>(names);
            //Console.WriteLine($"Element of index [1] :{Listnames.GetItem(1)}");
            //Console.WriteLine($"Element of index [5] :{Listnames.GetItem(5)}");
            #endregion
            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            //Answer:
            //Covariance allows you to use a more derived type than originally specified. Marked with out keyword. T can only appear in output positions.
            //It is commonly used with Interfaces like IEnumerable<T> and IQueryable<T>.

            #endregion
            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            //Answer:
            //Contravariance allows you to use a less derived type than originally specified. Marked with in keyword. T can only appear in input positions.
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
        #region FindMax
        public static T Max<T>(T[] arr,int n) where T :IComparable<T>
        {
            T max = arr[0];
            for(int i=0;i<n;i++)
            {
                if (arr[i].CompareTo(max) > 0)
                    max = arr[i];
            }
            return max;
        }
        #endregion

    }
}


namespace HashSet
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.Metrics;
    internal class Program
    {      
        static void Main(string[] args)
        {
            Predicate<string> lmbda = x => (x.Length > 7);
            int t = 0;
            HashSet<string> sample = new HashSet<string>();
            HashSet<string> samplex = new HashSet<string>();
            string enter;
            int capacity;
            sample.Add("object1");
            sample.Add("it's me!");
            sample.Add("that's hashset");
            sample.Add("cow"); 
            sample.Add("ryan gosling");

            while (t == 0){
                Console.WriteLine("Your main HashSet:");
                foreach (var i in sample){
                    Console.Write(" {0} |", i);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Your additional HashSet:");
                foreach (var i in samplex)
                {
                    Console.Write(" {0} |", i);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Add(Object) //1");
                Console.WriteLine("Clear() //2");
                Console.WriteLine("Contains(Object) //3");
                Console.WriteLine("EnsureCapacity(Int32) //4");//
                Console.WriteLine("Remove(Object) //5");//
                Console.WriteLine("IntersectWith(IEnumerable<T>) //6");
                Console.WriteLine("IsProperSubsetOf(IEnumerable<T>) //7");
                Console.WriteLine("Overlaps(IEnumerable<T>) //8");
                Console.WriteLine("SymmetricExceptWith(IEnumerable<T>) //9");
                Console.WriteLine("UnionWith(IEnumerable<T>) //0");
                Console.WriteLine("RemoveWhere(Predicate<T>) предикат x.Length < 7 //-");
                Console.WriteLine("заполнить сет №2 //w");
                Console.WriteLine("выход //любая клавиша");

                char k = Console.ReadKey(true).KeyChar;

                switch (k){
                    case '1':
                        while (true){
                            Console.Clear();
                            Console.WriteLine("введите первой строкой тип, второй - новый элемент //чтобы закончить, нажмите enter");
                            enter = Console.ReadLine();
                            if (enter == ""){
                                break;
                            }
                            sample.Add(enter);
                            Console.Clear();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        sample.Clear();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("введите новый элемент //чтобы закончить, нажмите enter");
                            enter = Console.ReadLine();
                            if (enter == "")
                            {
                                break;
                            }
                            Console.WriteLine(sample.Contains(enter));
                            Console.Clear();
                        }
                        break;
                    case '4':
                        Console.Clear();
                        capacity = int.Parse(Console.ReadLine());
                        int rang = sample.EnsureCapacity(capacity);
                        Console.WriteLine("теперь данный экземпляр hashset способен содержать без роста {0} элементов", rang);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '5':
                        Console.Clear();
                        enter = Console.ReadLine();
                        sample.Remove(enter);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '6':
                        Console.Clear();;
                        sample.IntersectWith(samplex);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '7':
                        Console.Clear();
                        Console.WriteLine(sample.IsProperSubsetOf(samplex));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '8':
                        Console.Clear();
                        Console.WriteLine(sample.Overlaps(samplex));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '9':
                        Console.Clear();
                        sample.SymmetricExceptWith(samplex);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '0':
                        Console.Clear();
                        sample.UnionWith(samplex);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '-':
                        Console.Clear();
                        sample.RemoveWhere(lmbda);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 'w':
                        Console.Clear();
                        Console.WriteLine("введите число элементов множества 2,а затем заполните его");
                        capacity = int.Parse(Console.ReadLine());
                        for (int i = 0; i < capacity; i++)
                        {
                            samplex.Add(Console.ReadLine());
                        }
                        Console.Clear();
                        break;
                    default:
                        t = 1;
                        break;
                }
            }
        } 
    }
}

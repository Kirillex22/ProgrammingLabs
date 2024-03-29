
namespace Dictionary{
    using System.Collections;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.Metrics;
    internal class Program{
        static void Main(string[] args){
            int key;
            int t = 0;
            Dictionary<int, string> sample = new Dictionary<int, string>(){
                { 1, "value1"},
                { 2, "popugai_kesha"},
                { 3, "blank"}
            };
            while (t == 0){
                string value = " ";
                Console.WriteLine("Your Dictionary:");
                foreach (var i in sample){
                    Console.Write(" ({0}, {1}) |", i.Key, i.Value);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Add(key,value) //1");
                Console.WriteLine("Clear() //2"); 
                Console.WriteLine("ContainsKey(int key) //3");
                Console.WriteLine("ContainsValue(string value) //4"); 
                Console.WriteLine("RemoveKey(int key) //5");
                Console.WriteLine("TryGetValue(int key) //6");
                Console.WriteLine("TryAdd(key, value) //7");
                Console.WriteLine("выход //любая клавиша");

                char k = Console.ReadKey(true).KeyChar;

                switch (k){
                    case '1':
                        while (true){
                            Console.Clear();
                            Console.WriteLine("введите первой строкой string значение, второй - ключ //чтобы закончить, введите любое число и нажмите enter");
                            value = Console.ReadLine();
                            if (value == "")
                                break;
                            key = int.Parse(Console.ReadLine());
                            sample.Add(key,value);
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
                        while (value != ""){
                            Console.Clear();
                            Console.WriteLine("введите key//чтобы закончить, нажмите enter");
                            value = Console.ReadLine();
                            if (value == "")
                                break;
                            key = int.Parse(value);
                            Console.WriteLine(sample.ContainsKey(key));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case '4':
                        while (value != ""){
                            Console.Clear();
                            Console.WriteLine("введите первой строкой тип, второй - элемент //чтобы закончить, нажмите enter");
                            value = Console.ReadLine();
                            if (value == "")
                                break;
                            Console.WriteLine(sample.ContainsValue(value));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case '5':
                        Console.Clear();
                        value = Console.ReadLine();
                        key = int.Parse(value);
                        sample.Remove(key);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '6':
                        Console.Clear();
                        string tmp;
                        value = Console.ReadLine();
                        key = int.Parse(value);
                        sample.TryGetValue(key, out tmp);
                        Console.WriteLine(tmp);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '7':
                        Console.Clear();
                        string type;
                        key = int.Parse(Console.ReadLine());
                        value = Console.ReadLine();
                        Console.WriteLine(sample.TryAdd(key, value));
                        Console.ReadKey();
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

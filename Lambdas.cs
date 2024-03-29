using System.ComponentModel;

namespace Lab_lambdas
{
    internal class Program
    {
        delegate int Toperator(int x, int y, int z);
        static void Main(string[] args)
        {
            int x, y, z;
            string[] mas;
            char input = ' ';
            Toperator Min = (x, y, z) => Math.Min(Math.Min(x, y), Math.Min(y, z));
            Toperator Max = (x, y, z) => Math.Max(Math.Max(x, y), Math.Max(y, z));
            Toperator Sum = (x, y, z) => x + y + z;
            Toperator Multiply = (x, y, z) => x * y * z;
            while (true){
                Console.Clear();
                input = ' ';
                Console.WriteLine("введите 3 числа // чтобы выйти, нажмите enter");
                try{
                    mas = Console.ReadLine().Split(' ');
                    x = int.Parse(mas[0]);
                    y = int.Parse(mas[1]);
                    z = int.Parse(mas[2]);
                }
                catch{
                    Console.Clear();
                    break;
                }
                Console.Clear();
                while(input != 'q'){
                    Console.Clear();
                    Console.WriteLine("Min(x,y,z) ----- 1");
                    Console.WriteLine("Max(x,y,z) ----- 2");
                    Console.WriteLine("Sum(x,y,z) ----- 3");
                    Console.WriteLine("Mpy(x,y,z) ----- 4");
                    Console.WriteLine("Ext(x,y,z) ----- q");
                    input = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    switch (input){
                        case '1':
                            Console.WriteLine(Min(x, y, z));
                            Console.ReadKey();
                            break;
                        case '2':
                            Console.WriteLine(Max(x, y, z));
                            Console.ReadKey();
                            break;
                        case '3':
                            Console.WriteLine(Sum(x, y, z));
                            Console.ReadKey();
                            break;
                        case '4':
                            Console.WriteLine(Multiply(x, y, z));
                            Console.ReadKey();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

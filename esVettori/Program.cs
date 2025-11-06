
namespace eserciziArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] num;
            num = new int[N];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("dammi un numero");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int z = num.Length - 1; z >= 0; z--)
            {
                Console.WriteLine($"[{num[z]}]");

            }
            Console.WriteLine("-----------------------------");
            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("dammi un numero");
                int n = Convert.ToInt32(Console.ReadLine());
                array[i] = n;
            }
            for (int i = 0; i < array.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine($"[{array[i]}]");
                }
            }

            Console.WriteLine("-----------------------------");

            int[] array2 = new int[N];

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Dammi un numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                array2[i] = num2;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    Console.WriteLine($"[{array2[i]}]");
                }
            }
            Console.WriteLine("-----------------------------");
            int[] array3 = new int[N];

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("Dammi un numero");
                int num3 = Convert.ToInt32(Console.ReadLine());

                array3[i] = num3;
            }
            int a = 0, p = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 != 0)
                {
                    a++;
                }
                else
                {
                    p++;
                }
            }
            Console.WriteLine("ci sono " + p + " numeri pari");
            Console.WriteLine("ci sono " + a + " numeri dispari");

            Console.WriteLine("-----------------------------");

            int[] array4 = new int[N];

            for (int i = 0; i < array4.Length; i++)
            {
                Console.WriteLine("Dammi un numero");
                int num4 = Convert.ToInt32(Console.ReadLine());

                array4[i] = num4;
            }
            int max = -10000, min = 10000, somma = 0;
            float media = 0;
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] > max)
                {
                    max = array4[i];
                }
                if (array4[i] < min)
                {
                    min = array4[i];
                }
                somma = array4[i] + somma;
            }
            media = somma / N;
            Console.WriteLine("il numero piu piccolo e: " + min);
            Console.WriteLine("il numero piu grande e: " + max);
            Console.WriteLine("la media e: " + media);

            Console.WriteLine("-----------------------------");

            int[] array5 = new int[N];
            int x = 0, v1 = 0, v2 = 0;
            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine("Dammi un numero");
                int num5 = Convert.ToInt32(Console.ReadLine());
             
                array5[i] = num5;
            }
            Console.WriteLine("Dammi un numero da analizzare");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array5.Length; i++)
            {
                    if (array5[i] < x)
                    {
                        Console.WriteLine("il numero " + array5[i] + " e minore del numero " + x);
                        v1++;
                    }
                    if (array5[i] > x)
                    {
                        Console.WriteLine("il numero " + array5[i] + " e maggiore del numero " + x);
                        v2++;
                    }
               
            }
            
        }
    }
}
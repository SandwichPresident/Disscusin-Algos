using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mean Code
            double sum = 0;
            Console.Write("n = ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n == 0) { Console.WriteLine("No result."); }
            int i = 0;
            do
            {
                Console.Write("a = ");
                double.TryParse(Console.ReadLine(), out double a);
                sum += a;
                i++;
            }
            while (i != n);
            double result = sum / n;
            Console.WriteLine($"Result: {result:F2}");

            //Median Code
            int numI;
            Console.Write("n = ");
            int.TryParse(Console.ReadLine(), out int nM);
            if (nM == 0) { Console.WriteLine("No result."); }
            int[] numbers = new int[nM];
            int iM = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out numI);
                numbers[iM] = numI;
                iM++;
            }
            while (iM != nM);
            int half = iM / 2;
            if (iM % 2 ==0)
            {
                int one = numbers[half];
                int two = numbers[half + 1];
                int mediam = (one + two) / 2;
            }
            else
            {
                int mediam = numbers[half];
            }


            // Min
            int ans = 0;
            Console.Write("n = ");
            int.TryParse(Console.ReadLine(), out int n2);
            if (n2 == 0) { Console.WriteLine("No result."); }
            int i2 = 0;
            do
            {
                Console.Write("a = ");
                int.TryParse(Console.ReadLine(), out int a);
                if (i2 == 0 || a < ans)
                {
                    ans = a;
                }
                i2++;
            }
            while (i2 != n2);
            Console.WriteLine($"Result: {ans}");



            // Max
            int answer = 0;
            Console.Write("n = ");
            int.TryParse(Console.ReadLine(), out int n3);
            if (n3 == 0) { Console.WriteLine("No result."); }
            int i3 = 0;
            do
            {
                Console.Write("a = ");
                int.TryParse(Console.ReadLine(), out int a);
                if (i3 == 0 || a > answer)
                {
                    answer = a;
                }
                i3++;
            }
            while (i3 != n3);
            Console.WriteLine($"Result: {answer}");

        }
    }
}

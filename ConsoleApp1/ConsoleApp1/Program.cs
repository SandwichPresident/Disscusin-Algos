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
                double mediam = (one + two) / 2;
            }
            else
            {
                int mediam = numbers[half];
            }
        }
    }
}

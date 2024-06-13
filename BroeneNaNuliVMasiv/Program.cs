namespace BroeneNaNuliVMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int zeroCount = 0;

            Console.WriteLine("Vuvedete 10 chisla");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Chislo {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    zeroCount++;
                }
            }

            Console.WriteLine($"Broqt na nulite e: {zeroCount}");
        }
    }
}

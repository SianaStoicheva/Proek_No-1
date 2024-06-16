namespace ZadachaSVuvedenMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete 20 elementa:");
            double[] array = new double[20];
            int count = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Chislo {i + 1}: ");
                double input = double.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                array[i] = input;
                count++;
            }

            int emptySlots = 20 - count;

            if (count > 0)
            {
                double minValue = array[0];
                double maxValue = array[0];
                int minIndex = 0;
                int maxIndex = 0;

                for (int i = 1; i < count; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                        minIndex = i;
                    }
                    if (array[i] > maxValue)
                    {
                        maxValue = array[i];
                        maxIndex = i;
                    }
                }

                Console.WriteLine($"{emptySlots}");
                Console.WriteLine($"Nai-malko chislo: {minValue} poziciq {minIndex + 1}");
                Console.WriteLine($"Nai-golqmo chislo: {maxValue} poziciq {maxIndex + 1}");
            }
            else
            {
                Console.WriteLine("Nqmahe vuvedeni chisla.");
            }
        }
    }
}

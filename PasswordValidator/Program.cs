namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            var length = false;
            var lettersDigits = true;
            var digits2 = false;
            int counterDigits = 0;

            if (password.Length >= 6 && password.Length <= 10)
            {
                length = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            for (int i = 0; i < password.Length; i++)
            {
                int current = password[i];

                if (current >= 48 && current <= 57)
                {
                    counterDigits++;
                }

                if (current < 48 || current > 122 || current > 90 && current < 97 || current > 57 && current < 65)
                {
                    lettersDigits = false;
                }
            }

            if (lettersDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (counterDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else if (counterDigits >= 2)
            {
                digits2 = true;
            }

            if (length && lettersDigits && digits2)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
                Console.ReadLine();
            }
        }
    }
}
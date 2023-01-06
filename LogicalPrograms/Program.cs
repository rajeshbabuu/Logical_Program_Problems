namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N terms for the Fibonacci Series: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("The Fibonacci Series for {0} terms are: ", N);
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < (N-2); i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
            }
            
        }
    }

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int remainder;

            while (n != 0)
            {
                remainder = n % 10;
                result = (result * 10) + remainder;
                n = n / 10;  //quotient
            }
            Console.WriteLine("The reverse is: " + result);
            Console.ReadLine();
        }
            
        }
    }

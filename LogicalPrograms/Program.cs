class CouponNumbers
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of coupons to generate: ");
        int couponsToGenerate = Convert.ToInt32(Console.ReadLine());
        int lengthOfCoupon = 8;

        List<string> generatedCoupons = new List<string>();
        char[] keys = "0123456789".ToCharArray();


        Console.WriteLine("Generated Coupons: ");
        while (generatedCoupons.Count < couponsToGenerate)
        {
            var coupon = GenerateCoupon(keys, lengthOfCoupon);
            if (!generatedCoupons.Contains(coupon))
            {
                generatedCoupons.Add(coupon);
                Console.WriteLine("\t[#{0}] {1}", generatedCoupons.Count, coupon);
            }
        }
        Console.WriteLine("done");
        Console.ReadLine();
    }

    private static string GenerateCoupon(char[] keys, int lengthOfCoupon)
    {
        return Enumerable
            .Range(1, lengthOfCoupon)
            .Select(k => keys[random.Next(0, keys.Length - 1)])
            .Aggregate("", (e, c) => e + c);
        

    }
    }

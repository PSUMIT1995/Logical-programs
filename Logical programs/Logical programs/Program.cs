using System;

namespace CouponNumber
{
    public class CouponNumber
    {
        public int N;
        public static void Coupon(int N)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(random.Next());
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N Value");
            CouponNumber c = new CouponNumber();
            int N = Convert.ToInt32(Console.ReadLine());
            CouponNumber.Coupon(N);

        }
    }
}
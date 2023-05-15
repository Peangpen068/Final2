using System;

class Program
{
    static void Main()
    {
        double B1, B2, B3;
        Console.WriteLine("Enter the initial balances (B1, B2, B3):");
        B1 = Convert.ToDouble(Console.ReadLine());
        B2 = Convert.ToDouble(Console.ReadLine());
        B3 = Convert.ToDouble(Console.ReadLine());

        double L = 0;
        double paidAmount;
        do
        {
            Console.WriteLine("Enter the amount paid:");
            paidAmount = Convert.ToDouble(Console.ReadLine());

            if (paidAmount >= B1)
            {
                paidAmount -= B1;
                B1 = 0;
            }
            else
            {
                B1 -= paidAmount;
                paidAmount = 0;
            }

            if (paidAmount >= B2)
            {
                paidAmount -= B2;
                B2 = 0;
            }
            else
            {
                B2 -= paidAmount;
                paidAmount = 0;
            }

            if (paidAmount >= B3)
            {
                paidAmount -= B3;
                B3 = 0;
            }
            else
            {
                B3 -= paidAmount;
                paidAmount = 0;
            }

            L += paidAmount;

            Console.WriteLine("Balance 1: {0}, Balance 2: {1}, Balance 3: {2}", B1, B2, B3);
        }
        while (paidAmount > 0);

        Console.WriteLine("Left: {0}", L);
    }
}

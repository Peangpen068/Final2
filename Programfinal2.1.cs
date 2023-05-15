using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the maximum tank capacity (Vmax):");
        double Vmax = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the average volume of water consumed during breaks (VdrinkVmax):");
        double VdrinkVmax = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time duration between breaks (tdaytdrink) in hours:");
        int tdaytdrink = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the time duration between refills (tdaytfill) in hours:");
        int tdaytfill = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the time duration of the entire activity (ttotal) in hours:");
        int ttotal = Convert.ToInt32(Console.ReadLine());

        double Vdrink = VdrinkVmax * Vmax;
        double Vfill = Vmax - Vdrink;
        double Vremaining = Vmax;
        int breaks = ttotal / tdaytdrink;
        int refills = ttotal / tdaytfill;

        for (int i = 0; i < breaks; i++)
        {
            if (Vremaining >= Vdrink)
            {
                Vremaining -= Vdrink;
            }
            else
            {
                Console.WriteLine("Not Enough Water");
                return;
            }

            if (i < refills)
            {
                if (Vremaining < Vfill)
                {
                    Console.WriteLine("Overflow Water");
                    return;
                }
                Vremaining -= Vfill;
            }
        }

        if (Vremaining >= 0)
        {
            Console.WriteLine("Enough Water, " + Vremaining + " left");
        }
    }
}


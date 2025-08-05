using System;

class TicketPriceCalculator
{
    static void Main()
    {
        int age;
        const decimal regularPrice = 10.00m;
        const decimal discountPrice = 7.00m;

        while (true)
        {
            Console.Write("Enter your age (or type 0 to exit): ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age == 0)
            {
                break;
            }

            decimal ticketPrice = (age >= 65 || age <= 12) ? discountPrice : regularPrice;
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
    }
}

using System;
public class deliverable1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");

        int totalpeople = int.Parse(Console.ReadLine());

        if (totalpeople <= 6) {
            Console.WriteLine("A table for " + totalpeople + "! Please follow me and take a seat.\r\nLet's get everyone started with some drinks. We've got water or coffee.\r\n");

            int c = 1;
            int coffeetotal = 0;
            int watertotal = 0;
            double buffetcost = 9.99;
            double coffeecost = 2.00;
            double watercost = 0.00;

            while (c <= totalpeople)
            {
                Console.WriteLine("Alright, person number " + c +", water or coffee?");
                c++;
                string a1 = Console.ReadLine(); 

                if (a1 == "coffee") {
                    coffeetotal = coffeetotal + 1;
                    Console.WriteLine(a1 + " okay!");
                } else if (a1 == "water")
                {
                    watertotal = watertotal + 1;
                    Console.WriteLine(a1 + " good choice!");
                } else
                {
                    Console.WriteLine("I'm sorry we do not have that drink, no drink for you.");
                }

            }

            Console.WriteLine("Okay, so that's " + coffeetotal + " coffees and "+ watertotal + "waters. I'll be right back. Feel free to grab your food!");

            double totalcoffeeprice = coffeetotal * coffeecost;
            double totalwaterprice = watertotal * watercost;
            double totalbuffetpricee = totalpeople * buffetcost;
            double totalprice = totalcoffeeprice + totalwaterprice + totalbuffetpricee;


            Console.WriteLine("Here's your bill! Total price: $" + totalprice);
           

        } else
        {
            Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
        }


    }
}
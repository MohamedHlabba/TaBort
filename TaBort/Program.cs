using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name : ");
            string name = Console.ReadLine();



            Console.WriteLine("How many hours hade you sleep");
            var hoursAsString = Console.ReadLine();
            int hours;

            while (!int.TryParse(hoursAsString, out hours))
            {
                Console.WriteLine("This is not a number!");
                hoursAsString = Console.ReadLine();
            }



            Console.WriteLine($"You sleep : {hours}  hours");






            //int hoursofsleep = int.Parse(Console.ReadLine());



            if (hours >= 8)
            {
                Console.WriteLine("you sleep enough " + "you are well rested " + name);



            }
            else
            {
                Console.WriteLine("you need to take a rest ");

            }



            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Package
    {
        int weight { get; set; }
        int width { get; set; }
        int height { get; set; }
        int length { get; set; }
        public Package(int weight, int width, int height, int length)
        {
            this.weight = weight;
            this.width = width;
            this.height = height;
            this.length = length;
        }
        public void getPackage()
        {
            Console.WriteLine("Please Enther the package weight");
            weight = Int32.Parse(Console.ReadLine());
            if(weight > 50)
            {
                Console.WriteLine("To heavy to ship package");
                return;
            }
            Console.WriteLine("Please Enther the package width");
            width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enther the package height");
            height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enther the package length");
            length = Int32.Parse(Console.ReadLine());
            if(width + height + length > 50)
            {
                Console.WriteLine("Package to bug to be shipped");
                return;
            }

        }
        public void totalCost()
        {
            double x = 100;
            double cost = ((width + height + length) * weight) / x;
            if ((cost == 0) || width + height + length > 50)
            {
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Total Cost to ship is ${0}", Math.Round(cost, 2));
                Console.ReadLine();
            }
        }
            
    }
}

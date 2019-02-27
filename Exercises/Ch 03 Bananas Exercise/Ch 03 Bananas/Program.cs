using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_03_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pounds = getPounds();
            double dPricePerPound = getdPricePerPounds();
            double dPriceWithTax = getTaxPrice(int Pounds, double dPricePerPound);
            printPrice(dPriceWithTax)

        }

        private static void printPrice(double dPriceWithTax)
        {
            Console.WriteLine("$The total price of bananas with tax  ")
        }

        private static double getTaxPrice(double pounds, double dPricePerPound)
        {
            double netPrice = (pounds *  dPricePerPound);
            double tax = (netPrice * .03);
            double getTaxPrice = (netPrice + tax);
            return (getTaxPrice);
        
        }

        private static double getdPricePerPounds()
        {
            Console.WriteLine("Enter price per pound: ");             //get get 
            string PricePerPound = Console.ReadLine();                //read price
            double dPricePerPound = double.Parse(PricePerPound);      //convert price 
            return (dPricePerPound);                                  //give price back

        }
        private static double getPounds()
        {
            Console.WriteLine("Enter amoung of pounds of bananas: "); //prompt user to enter pounds of bananas 
            string strPounds = Console.ReadLine();                    //read the pounds per banana
            double Pounds = int.Parse(strPounds);                     //convert pounds per banana double 
            return (Pounds);                                          //return pounds per banana 
            
        }
    }
}

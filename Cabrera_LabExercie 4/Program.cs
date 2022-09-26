using System;

namespace Cabrera_LabExercie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char prodCode;
      
            products:
            Console.WriteLine("\t\t\t\t\t J  U  M  P  W  A  N  ");
            Console.WriteLine("\n\t - - - - C O D E - - - - N A M E  O F  P R O D U C T S - - - -  P R I C E - - - - ");
            Console.WriteLine("\n\t\t   J-1\t\t Air Jordan 1 Mid SE (M)\t\tPHP 6,295.99");
            Console.WriteLine("\n\t\t   U-2\t\t Nike Air Force 1 '07 (M)\t\tPHP 4,795.75");
            Console.WriteLine("\n\t\t   M-3\t\t Jordan Delta (M)\t\t\tPHP 6,745.50");
            Console.WriteLine("\n\t\t   P-4\t\t Nike Air Max 270 React ENG (W)\t\tPHP 8,695.99");
            Console.WriteLine("\n\t\t   W-5\t\t Nike Air Force 1 Shadow (W)\t\tPHP 5,895.75");
            Console.WriteLine("\n\t\t   A-6\t\t Nike Air Zoom Tempo Next (W)\t\tPHP 10,195.50");
            Console.WriteLine("\n\t\t   N-7\t\t LeBron Basketball Backpack \t\tPHP 3,295.99");

            Console.Write("\n\tEnter Product LETTER Code: ");
            prodCode = Convert.ToChar(Console.ReadLine().ToUpper());
            
            
            switch (prodCode)
            {
                case 'J':
                    Console.WriteLine("\nMens: Air Jordan 1 Mid SE");
                    Console.WriteLine("Product Price: PHP 6,295.99");
                    break;
                case 'U':
                    Console.WriteLine("\nMens: Nike Air Force 1 '07 ");
                    Console.WriteLine("Product Price: PHP 4,795.75");
                    break;
                case 'M':
                    Console.WriteLine("\nMens: Jordan Delta");
                    Console.WriteLine("Product Price: PHP 6,745.50");
                    break;
                case 'P':
                    Console.WriteLine("\nWomens: Nike Air Max 270 React ENG");
                    Console.WriteLine("Product Price: PHP 8,695.99");
                    break;
                case 'W':
                    Console.WriteLine("\nWomens: Nike Air Force 1 Shadow");
                    Console.WriteLine("Product Price: PHP 5,895.75");
                    break;
                case 'A':
                    Console.WriteLine("\nWomens: Nike Air Zoom Tempo Next");
                    Console.WriteLine("Product Price: PHP 10,195.50");
                    break;
                case 'N':
                    Console.WriteLine("\nLeBron Basketball Backpack");
                    Console.WriteLine("Product Price: PHP 3,295.99");
                    break;
                default:
                    Console.WriteLine("\nINVALID PRODUCT NUMBER CODE....PLEASE TRY AGAIN! ");
                    goto products;
            }

            int quantity, prodNum;
            double cash, prodPrice, subTotal, vat, totPrice, change;

            Console.WriteLine();
            Console.WriteLine("\t- - - - P A Y M E N T  D E T A I L S - - - -");
            
            Console.Write("\n\tEnter Product NUMBER code of choice: ");
            prodNum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\tEnter Product Quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\tEnter the Product Price of choice");
            Console.Write("\t\tPHP ");
            prodPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\tEnter Cash in Hand");
            Console.Write("\t\tPHP ");
            cash = Convert.ToDouble(Console.ReadLine());

            subTotal = prodPrice * quantity;
            vat = .20 * subTotal;
            totPrice = subTotal + vat;
            change = cash - totPrice;

            if (prodNum == 1)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t JUMPWAN PRICE CLUB, INC.");
                Console.WriteLine("\t\t A.BONIFACIO AVE BRGY BALINGASA QUEZON CITY");
                Console.WriteLine("\t\t\tTRANS. DATE: 09/25/2020 13:39:00" );
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: Air Jordan 1 Mid SE (Mens)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 6,295.99");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice,2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change, 2));
            }
           else if (prodNum == 2)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t JUMPWAN PRICE CLUB, INC. ");
                Console.WriteLine("\t\t\t\t\tA.BONIFACIO AVE BRGY BALINGASA QUEZON CITY ");
                Console.WriteLine("\t\t\t\t\tTRANS. DATE: 09/25/2020 13:39:00  ");
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: Nike Air Force 1 '07 (Mens)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 4,795.75");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice, 2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change, 2));
            }

            else if (prodNum == 3)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t JUMPWAN PRICE CLUB, INC.");
                Console.WriteLine("\t\t A.BONIFACIO AVE BRGY BALINGASA QUEZON CITY");
                Console.WriteLine("\t\t\tTRANS. DATE: 09/25/2020 13:39:00");
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: Jordan Delta (Mens)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 6,745.50");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice, 2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change,2));
            }

            else if (prodNum == 4)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t JUMPWAN PRICE CLUB, INC.");
                Console.WriteLine("\t\t A.BONIFACIO AVE BRGY BALINGASA QUEZON CITY");
                Console.WriteLine("\t\t\tTRANS. DATE: 09/25/2020 13:39:00");
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: Nike Air Max 270 React ENG (Womens)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 8,695.99");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice, 2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change, 2));
            }

            else if (prodNum == 5)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t JUMPWAN PRICE CLUB, INC.");
                Console.WriteLine("\t\t A.BONIFACIO AVE BRGY BALINGASA QUEZON CITY");
                Console.WriteLine("\t\t\tTRANS. DATE: 09/25/2020 13:39:00");
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: Nike Air Force 1 Shadow (Womens)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 5,895.75");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice, 2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change, 2));
            }

            else if (prodNum == 6)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t JUMPWAN PRICE CLUB, INC.");
                Console.WriteLine("\t\t A.BONIFACIO AVE BRGY BALINGASA QUEZON CITY");
                Console.WriteLine("\t\t\tTRANS. DATE: 09/25/2020 13:39:00");
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: Nike Air Zoom Tempo Next (Womens)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 10,195.50");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice, 2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change, 2));
            }

            else if (prodNum == 7)
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t JUMPWAN PRICE CLUB, INC.");
                Console.WriteLine("\t\t A.BONIFACIO AVE BRGY BALINGASA QUEZON CITY");
                Console.WriteLine("\t\t\tTRANS. DATE: 09/25/2020 13:39:00");
                Console.WriteLine();
                Console.WriteLine("\tSelected Product: LeBron Basketball Backpack (Sports Bag)");
                Console.WriteLine();
                Console.WriteLine("\tProduct Price:\t\tPHP 3,295.99");
                Console.WriteLine();
                Console.WriteLine("\tSubtotal:\t\tPHP " + Math.Round(subTotal, 2));
                Console.WriteLine();
                Console.WriteLine("\tVAT:\t\t\tPHP " + Math.Round(vat, 2));
                Console.WriteLine();
                Console.WriteLine("\tTotal Price:\t\tPHP " + Math.Round(totPrice, 2));
                Console.WriteLine();
                Console.WriteLine("\t\t\tCASH:\t\tPHP " + cash);
                Console.WriteLine("\t ---------------------------------------------------------");
                Console.WriteLine("\t\t\tCHANGE:\t\tPHP " + Math.Round(change));
            }

            else
            {
                Console.WriteLine("\nINVALID PRODUCT NUMBER CODE .... PLEASE TRY AGAIN! ");
            }

            Console.ReadKey();
        }
    }
}

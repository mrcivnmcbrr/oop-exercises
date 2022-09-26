using System;


namespace midterm_Number3
{
    public class Customers
    {
        //PROPERTIES
        public string name;
        public string location;
        public string contactNumber;
        public string productID;
        public double price;
        public int quantity;
        public double cash;
        public double totalAmount;
        public double change;

        //METHOD
        public void ViewCustomerDetails()
        {
            Console.Write("Enter Customer Name:\t");
            name = Console.ReadLine();
            Console.Write("Enter Location:\t\t");
            location = Console.ReadLine();
            Console.Write("Enter Contact Number:\t");
            contactNumber = Console.ReadLine();
        }
        public void ViewProducts()
        {

            Console.WriteLine("\tID\t\tProduct\t\tPrice\t");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\t01\t\tAlcohol\t\t35.43\t");
            Console.WriteLine("\t02\t\tFace Mask\t10\t");
            Console.WriteLine("\t03\t\tGloves\t\t9.16\t");
            Console.WriteLine("\t04\t\tFace Shield\t20\t");
            Console.WriteLine("\t05\t\tTissue\t\t25.31\t\n");

            Console.WriteLine("");

        }
        public void CustomerReceipt()
        {

            Customers cut = new Customers();

            Console.Write("Enter Product Code:\t");
            productID = Console.ReadLine();

            Console.Write("Quantity:\t\t");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cash:\t\t\t");
            cash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (productID)
            {
                case "01":
                    price = 35.40;
                    totalAmount = quantity * price;
                    change = cash - totalAmount;

                    cut.ViewCustomerDetails();
                    Console.WriteLine("Customer Name:\t{0}" + cut.name);
                    Console.WriteLine("Product ID:\t{0}", productID);
                    Console.WriteLine("**************************");
                    Console.WriteLine("\nTotal Amount:\tPhp {0}", totalAmount);
                    Console.WriteLine("Change:\t\tPhp {0}", change);
                    break;

                case "02":
                    price = 10;
                    totalAmount = quantity * price;
                    change = cash - totalAmount;

                    Console.WriteLine("Customer Name:\t{0}", name);
                    Console.WriteLine("Product ID:\t{0}", productID);
                    Console.WriteLine("**************************");
                    Console.WriteLine("Total Amount:\tPhp {0}", Math.Round((Decimal)totalAmount, 2));
                    Console.WriteLine("Change:\t\tPhp {0}", Math.Round((Decimal)change, 2));
                    break;

                case "03":
                    price = 9.10;
                    totalAmount = quantity * price;
                    change = cash - totalAmount;

                    Console.WriteLine("Customer Name:\t{0}", name);
                    Console.WriteLine("Product ID:\t{0}", productID);
                    Console.WriteLine("**************************");
                    Console.WriteLine("Total Amount:\tPhp {0}", totalAmount);
                    Console.WriteLine("Change:\t\tPhp {0}", change);
                    break;

                case "4":
                    price = 20;
                    totalAmount = quantity * price;
                    change = cash - totalAmount;

                    Console.WriteLine("Customer Name:\t{0}", name);
                    Console.WriteLine("Product ID:\t{0}", productID);
                    Console.WriteLine("**************************");
                    Console.WriteLine("Total Amount:\tPhp {0}", totalAmount);
                    Console.WriteLine("Change:\t\tPhp {0}", change);
                    break;

                case "5":

                    price = 25.30;
                    totalAmount = quantity * price;
                    change = cash - totalAmount;

                    Console.WriteLine("Customer Name:\t{0}", name);
                    Console.WriteLine("Product ID:\t{0}", productID);
                    Console.WriteLine("************************");
                    Console.WriteLine("Total Amount:\tPhp {0}", totalAmount);
                    Console.WriteLine("Change:\t\tPhp {0}", change);
                    break;

                default:
                    Console.WriteLine("Undefined ");
                    break;

            }
        }


        static void Main(string[] args)
        {
            string choice;
            do
            {
                Customers viewProd = new Customers();

                viewProd.ViewCustomerDetails();
                viewProd.ViewProducts();
                viewProd.CustomerReceipt();

                Console.Write("\nDo you want to do Another Application? (Yes or No):\t");
                choice = Console.ReadLine();
                Console.WriteLine();

            } while (choice == "yes" || choice == "Yes");
            Console.WriteLine("\nThank You For Your Purchase!");
            Console.WriteLine("Programmer: Allyza Pantola");

            Console.ReadLine();

        }
    }
}
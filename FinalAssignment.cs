using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class CheckCart
    {
        public string pName { get; set; }
        public int pQuantity { get; set; }
    }

    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }

        public string pDescription { get; set; }

        public int pPrice { get; set; }
    }
    public class Authentication
    {
        public bool Login (string username, string password)
        {
            bool isloggedin = false;

            if (!isloggedin)
            {
                if (username == "admin" && password == "password")
                {
                    isloggedin = true;
                    return true;
                }
                else
                {
                    isloggedin = false;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("User ALready Logged IN");
                Console.WriteLine();
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Home Page");
            //Console.WriteLine();

            Console.WriteLine("For Login: Press 1");
            Console.WriteLine();
            Console.WriteLine("For Registration: Press 2");
            Console.WriteLine();

            string action = Console.ReadLine();

            if (action == "2")
            {
                Console.WriteLine("Rigistration Closed!");
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                Authentication login = new Authentication();

                Console.WriteLine("Enter UserName");
                Console.WriteLine();

                string username = Console.ReadLine();

                Console.WriteLine("Enter Password");
                Console.WriteLine();

                string password = Console.ReadLine();

                try
                {
                    bool IsLoggedIn = login.Login(username, password);
                    if (IsLoggedIn)
                    {
                        Console.WriteLine("Login Successfull");
                       
                        List<Products> products = new List<Products>();

                        List<CheckCart> carts = new List<CheckCart>();

                        products.Add(new Products { pId = 1, pName = "Mobile", pDescription = "Samsung S24", pPrice = 30000 });
                        products.Add(new Products { pId = 2, pName = "Laptop", pDescription = "HP EliteBook", pPrice = 75000 });
                        products.Add(new Products { pId = 3, pName = "Smart Watch", pDescription = "Stationery", pPrice = 2500 });
                        
                        Console.WriteLine();

                        foreach (var item in products)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Available Products in the store are: ");
                            Console.WriteLine();
                            Console.WriteLine(item.pId+", " + item.pName + ", " + item.pDescription+", " + item.pPrice);
                        }

                        int result = 2;

                        while (result != 1)
                        {
                          
                            Console.WriteLine("Please Select Product ID for adding to cart");

                            int id = int.Parse(Console.ReadLine());

                            switch (id)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter Quantity");
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new CheckCart { pQuantity = Q, pName = "Mobile" });
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Enter Quantity");
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new CheckCart { pQuantity = Q, pName = "Laptop" });
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Enter Quantity");
                                        int Q = int.Parse(Console.ReadLine());
                                        carts.Add(new CheckCart { pQuantity = Q, pName = "SmartWatch" });
                                    }
                                    break;
                                default:
                                    throw new Exception("Please select a valid Item, Invalid Item Selected");
                                    break;
                            }
                            foreach (var item in carts)
                            {
                                Console.WriteLine(item.pName + "  " + item.pQuantity);
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine("Do you want to Check Out?");
                            Console.WriteLine();

                            Console.WriteLine("1.Yes");
                            Console.WriteLine();
                            Console.WriteLine("2.No");
                            Console.WriteLine();

                            result = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Order Confirmed, Thanks for Shopping");
                        Console.WriteLine();
                    }
                    else
                    {
                        throw new Exception("Invalid Credentials");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}

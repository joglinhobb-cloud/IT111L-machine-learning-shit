using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project_Shelfy_Automotives
{

    internal class testing
    {


        //penis ballsack
        static string GetUserName()
        {
            while (true)
            {
                Console.Write("Enter usename: ");
                string name1 = Console.ReadLine();
                if (!name1.All(n => char.IsLetter(n)))
                {
                    Console.WriteLine("Error! must contain string.");
                    Console.ReadKey();
                    continue;
                }
                else if (name1.Length < 1)

                {
                    Console.WriteLine("Error! Length.");
                    Console.ReadKey();
                }

                Console.Write("Enter password: ");

                string password1 = Console.ReadLine();
                if (password1.Length < 1)  //password.Length != 10
                {
                    Console.WriteLine("Error! Length.");
                    Console.ReadKey();
                    continue;
                }
                else if (!password1.All(n => char.IsLetter(n)))
                {
                    Console.WriteLine("Error must be number! ");
                    Console.ReadKey();
                    continue;
                }
            }
            return null;
        }
        static string GetUserPassword()
        {
            while (true)
            {

            }
            return null;
        }
        static string GetUserType()
        {
            while (true)
            {

            }
            return null;
        }
        static string EmployeeNumberM()
        {
           
           
            return null;
        }
        static string EmployeeNumberS()
        {
            
            return null;
        }

        //------------------------------------------------------------------------------------
        static void UserManagement()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("::: User Management :::");
                    Console.WriteLine("1. Create Account\n2. Change my password\n3. Change user type\n4. List employees\n5. Deactivate Account\n0. Back");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }
        static void ProductManagement()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("::: Product Management :::");
                    Console.WriteLine("1. Add new part\n2. Edit part details\n3. Remove part\n4. View inventory\n5. Show total inventory value\n0. Back");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }
        static void SupplierManagement()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("::: Supplier Management :::");
                    Console.WriteLine("1. Add supplier\n2. Update supplier (products and status)\n3. List active suppliers\n4. List products of one supplier\n0. Back");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }

        static void InventoryManagement()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("::: Inventory Management :::");
                    Console.WriteLine("1. Stock-In\n2. Stock-Out\n3. Declare Damage Goods\n4. Update safety level\n5. Products below safety level\n6. Products at or above safety level\n7. View transaction log\n0. Back");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }
        static void ReportManagement()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("::: Report Management :::");
                    Console.WriteLine("1. Most released items\n2. Most and least preferred supplier\n0. Back");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }
        static void Manager()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("Welcome, Manager Nigger!");
                    Console.WriteLine("1. User Management\n2. Product Management\n3. Supplier Management\n4. Inventory Management\n5. Reports\n0. Log-Out");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            UserManagement();
                            break;
                        case 2:
                            ProductManagement();
                            break;
                        case 3:
                            SupplierManagement();
                            break;
                        case 4:
                            InventoryManagement();
                            break;
                        case 5:
                            ReportManagement();
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }

        static void Staff()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("Welcome, Staff Nigger!");
                    Console.WriteLine("1. Stock-In\n2. Stock-Out\n3. Declare Damage Goods\n4. View Inventory\n5. Change my password \n0. Log-Out");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 0:
                            running = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Error!"); continue; }
            }
        }


        static void Main(string[] args)
        {
            string[] type = new string[1];
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("1. Login\n2. Sign up\n3. Exit");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: //---------------------------- Login
                            Console.Write("Enter usename: ");
                            string name1 = Console.ReadLine();
                            if (!name1.All(n => char.IsLetter(n)))
                            {
                                Console.WriteLine("Error! must contain string.");
                                Console.ReadKey();
                                continue;
                            }
                            else if (name1.Length < 1)

                            {
                                Console.WriteLine("Error! Length.");
                                Console.ReadKey();
                            }

                            Console.Write("Enter password: ");

                            string password1 = Console.ReadLine();
                            if (password1.Length < 1)  //password.Length != 10
                            {
                                Console.WriteLine("Error! Length.");
                                Console.ReadKey();
                                continue;
                            }
                            else if (!password1.All(n => char.IsLetter(n)))
                            {
                                Console.WriteLine("Error must be number! ");
                                Console.ReadKey();
                                continue;
                            }
                            if (type[0] == "MANAGER")
                            {
                                Manager();
                            }
                            else if (type[0] == "STAFF")
                            {
                                Staff();
                            }
                            type[0] = null;
                            break;

                        case 2: //---------------------------- Sign up
                            Console.Write("Enter Employee Number: ");
                            int eNum = Int32.Parse(Console.ReadLine());

                            Console.Write("Enter Employee Name: ");
                            string eName = Console.ReadLine();

                            Console.Write("Enter username: ");
                            string name2 = Console.ReadLine();

                            Console.Write("Enter password: ");
                            string password2 = Console.ReadLine();

                            Console.Write("Enter type of user (Manager / Staff): ");
                            type[0] = Console.ReadLine().ToUpper();
                            Console.WriteLine("Sign-up successful!");
                            Console.ReadKey();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            continue;
                    }
                }
                catch (Exception) //---- will catch anything out of range/variable error
                {
                    Console.WriteLine("Error!");
                    continue;
                }


            }
        }
    }
}
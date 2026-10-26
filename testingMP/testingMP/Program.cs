using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project_Shelfy_Automotives
{

    public enum AccountType
    {
        Manager,
        Staff,
    };

    public enum AccountStatus
    {
        Activated,
        Deactivated,
            
    }
    class StaffManagement()
    {
        private List<Employee> listOfEmployees = new List<Employee>(); //created once and saved in here to avoid tamperment


        //methods: check if employee list is empty, add new employee
        //
    };
    class Employee
    {
        //attributes ---------------------------------------------------
        string EmployeeNo;
        string FullName;
        string Username;
        private string Password;
        AccountStatus AccountStatus;

        public Employee(string EmployeeNo, string FullName, string Username, string Password) //For Create New Account.
        {
            this.EmployeeNo = EmployeeNo;
            this.FullName = FullName;
            this.Username = Username;
            this.Password = Password;
            this.AccountStatus = AccountStatus.Activated; //New Accounts start Active.
        }

        //list of methods. ---------------------------------------------------
        bool CheckPassword(string attempedPassword)
        {
            return false;
        }
        bool ChangePassword(string newPassword)
        {
            return false;
        }
        void Deactivate() //List<Employee> employees, string targetEmpNo
        {
            AccountStatus = AccountStatus.Deactivated;
        }
        static bool IsActive()
        {
            return false;
        }
        public virtual string GetUserType()
        {
            return "a";
        }
        public virtual void ShowMenu()
        {

        }
    };

    class Manager: Employee //Manager inherits the Attributes and public methods of Employee (probably the privated method ones as well)
    {
        static bool CreateAccount(List<Employee> employees,string empNo, string fullName, string username, string password, string userType) //reject empty name, empty password, duplicates, user type that is not manager or staff.
        {
            return false;
        }
        static bool ChangeUserType()  
        {
            return false;
        }
        static void ListEmployees() //Show List of Employees
        {

        }
        static void ChangeAccountStatus() //Activate/Deactivate Specified Account
        {

        }
        static void ChangePassword()
        {

        }

        static AccountStatus Deactivate() //List<Employee> employees, string targetEmpNo 
        {
            return AccountStatus.Deactivated;
        }
        static AccountStatus Activate()
        {
            return AccountStatus.Activated;

        }
        public Manager(string EmployeeNo, string FullName, string Username, string Password) : base (EmployeeNo, FullName, Username, Password) 
        {

        }
        
    };
    class Staff:Employee
    {
        static void ChangePassword()
        {

        }
        public Staff(string EmployeeNo, string FullName, string Username, string Password) : base(EmployeeNo, FullName, Username, Password)
        {

        }
    };
















    
    //put it inside json insstead of txt
    //  
    internal class testing
    {


        //penis ballsack  
        static string GetUserName() //polymorph
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter usename: ");
                string name1 = Console.ReadLine();
                if (!name1.All(n => char.IsLetter(n)))
                {
                    Console.Clear();
                    Console.WriteLine("Error! must contain string.");
                    Thread.Sleep(400);
                    continue;
                }
                else if (name1.Length < 1)

                {
                    Console.Clear();
                    Console.WriteLine("Error! Invalid Length..");
                    Thread.Sleep(400);
                }
                return name1;

            }
        }
        static string GetUserPassword()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter password: ");
                string password1 = Console.ReadLine();
                if (password1.Length != 10)  
                {
                    Console.Clear();
                    Console.WriteLine("Error! must be 10 digits.");
                    Thread.Sleep(400);
                    continue;
                }
                else if (!password1.All(n => char.IsDigit(n)))
                {
                    Console.Clear();
                    Console.WriteLine("Error! must be a digit!.");
                    Thread.Sleep(400);
                    continue;
                }
                return password1;
            }
         
        }
        static bool GetUserType()
        {
            
            while (true)
            {
                Console.Write("Manager/Staff?: ");  

                string Usertype = Console.ReadLine();

                if (Usertype.Length < 1)  //password.Length != 10
                {   
                    Console.WriteLine("Error! Length.");
                    Console.ReadKey();
                    continue;
                }
                else if (!Usertype.All(n => char.IsLetter(n)))
                {
                    Console.WriteLine("Error must be number! ");
                    Console.ReadKey();
                    continue;
                }
                if (Usertype == "manager" || Usertype == "staff")
                {

                }
            }
            

        }
        static bool CheckUserName()
        {
            return false;
        }

        static bool CheckUserPassword()
        {
            return false;
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
                            
                            
                            type[0] = null;
                            break;

                        case 2: //---------------------------- Sign up
                            string Savedusername = GetUserName();

                            string Savedpassword = GetUserPassword();

                            
                            
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
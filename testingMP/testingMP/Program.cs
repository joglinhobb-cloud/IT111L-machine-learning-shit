using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project_Shelfy_Automotives
{

    public enum AccountType //enum is like a class Manager = 0 , Staff = 1;
    {
        Manager, //0
        Staff, // 1
        None, //2
    };

    public enum AccountStatus
    {
        Deactivated,
        Activated,
            
    }
    class StaffManagement()
    {
        private List<Employee> listOfEmployees = new List<Employee>(); //created once and saved in here to avoid tamperment


        //methods: check if employee list is empty, add new employee
        //
        public static string GetFullName() //polymorph
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter Full Name: ");
                string name1 = Console.ReadLine();
                if (!name1.All(n => char.IsLetter(n) || n == ' ' || n == '.'))
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
        public static string GetUserName() //polymorph
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
        public static string GetUserPassword()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter password: ");
                string password1 = Console.ReadLine();
                if (password1.Length < 4)
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
        public static AccountType GetUserType()
        {

            while (true)
            {
                Console.Write("Manager (M) /Staff (S)?: ");

                string Usertype = Console.ReadLine().ToUpper();

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

        public static AccountStatus SetDefaultAccountStatus()
        {
            return AccountStatus.Activated; // = 1
        }
        public static Employee CreateManager()
        {
            string EmployeeNo = "12345";
            string FullName = GetFullName();
            string Username = GetUserName();
            string Password = GetUserPassword();
            AccountType accountType =AccountType.Manager;
            AccountStatus accountStatus = SetDefaultAccountStatus();


            Employee newManagerAccount = new Employee(EmployeeNo,FullName,Username,Password,accountType,accountStatus);


            return newManagerAccount;
        }

        public bool IsEmployeeListEmpty()
        {
            if (listOfEmployees.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void AddNewEmployee(Employee tobeSentInsideList) //this is called in main when ever we have made a new Employee. After that it adds to the List.

        {

            listOfEmployees.Add(tobeSentInsideList);  //since our list is private we can access it here and use this method to add from main yes.
            
        }

        public void PrintEmployeeList()
        {
            if (listOfEmployees.Count != 0)
            {
                foreach (Employee n in listOfEmployees)
                {
                    Console.WriteLine(n.accessListEmployee());
                }
            }
            else
            {
                Console.WriteLine("It's still empty retard");
                Thread.Sleep(400);
            }
         
           
        }
    };
    class Employee
    {
        //attributes ---------------------------------------------------
        protected string EmployeeNo;
        protected string FullName;
        protected string Username;
        protected string Password;
        protected AccountType accountType;
        protected AccountStatus accountStatus;

        public Employee(string EmployeeNo, string FullName, string Username, string Password,AccountType accountType, AccountStatus accountStatus) //For Create New Account.
        {
            this.EmployeeNo = EmployeeNo;
            this.FullName = FullName;
            this.Username = Username;
            this.Password = Password;
            this.accountType = accountType; //New Accounts start with no Type.  btw hard coded
            this.accountStatus = AccountStatus.Activated; //New Accounts start Active.
        }

        public string accessListEmployee() // this is for our printing, using this method inside of the variable will give that print method access to the Employee datatype inside the list.
            //without this you can't print the contents of the list.   in short it's more like a gate pass
        {
            return $"{EmployeeNo},{FullName},{Username},{Password},{accountType},{accountStatus}";
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
            accountStatus = AccountStatus.Deactivated;
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
        static bool CreateAccountManager(List<Employee> employees,string empNo, string fullName, string username, string password, string userType, AccountStatus accountStatus) //reject empty name, empty password, duplicates, user type that is not manager or staff.
        {
            return false; // return false if account already eixists return true if it does not exist
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
        public Manager(string EmployeeNo, string FullName, string Username, string Password, AccountType accountType, AccountStatus accountStatus) : base (EmployeeNo, FullName, Username, Password, accountType, accountStatus) 
        {

        }
        
    };
    class Staff:Employee
    {
        static void ChangePassword()
        {

        }
        public Staff(string EmployeeNo, string FullName, string Username, string Password, AccountType accountType, AccountStatus accountStatus) : base(EmployeeNo, FullName, Username, Password, accountType, accountStatus)
        {

        }
    };

    internal class testing
    {

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
            StaffManagement accessStaffManagement = new StaffManagement();
            string[] type = new string[1];
            while (true)
            {
                try
                {
                    
                    Console.WriteLine("===== PROJECT: Shelfy Automotives Inventory Management =====\n");
                    Console.WriteLine("1. Login\n2. Sign up\n3. Exit");
                    Console.Write("Enter choice: ");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: //---------------------------- Loginw   

                            break;

                        case 2: //----------------- ----------- Sign up


                            if (accessStaffManagement.IsEmployeeListEmpty()) 
                            {

                                //tip if we are calling a method inside of a class and it doesn't have "static" please refer to the class Name then method. Like for instance, CreateManager()
                                Employee tobeSentInsideList = StaffManagement.CreateManager();  //once created a new manager we create a variable and Manager information is palced inside this variable to be placed inside the list later.

                                
                                accessStaffManagement.AddNewEmployee(tobeSentInsideList);
                                

                            }
                            
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        case 4:
                            accessStaffManagement.PrintEmployeeList();
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
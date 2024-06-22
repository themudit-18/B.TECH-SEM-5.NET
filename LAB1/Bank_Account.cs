using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bank_Account
    {
        long Account_no;
        String? Email;
        String? User_Name;
        String? Account_Type;
        Double Account_Balance;


        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Number::");
            this.Account_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Email::");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter Your User Name::");
            this.User_Name = Console.ReadLine();
            Console.WriteLine("Enter Type Of Your Account::");
            this.Account_Type = Console.ReadLine();
            Console.WriteLine("Enter Your Balance..:");
            this.Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("<==========Your Details==========>");
            Console.WriteLine("Your Account Number is::" + this.Account_no);
            Console.WriteLine("Your Email is::" + this.Email);
            Console.WriteLine("Your User Name is::" + this.User_Name);
            Console.WriteLine("Your Account Type is::" + this.Account_Type);
            Console.WriteLine("Your Account Balance is::" + this.Account_Balance);
        }
    }
}

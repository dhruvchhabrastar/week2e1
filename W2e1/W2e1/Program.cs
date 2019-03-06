using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2e1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The person's details...");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Credit Card number: ");
            long creditNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("CVC: ");
            int cvc = int.Parse(Console.ReadLine());

            Console.Write("Expire Date: ");
            string date = Console.ReadLine();

            CreditCard c1 = new CreditCard();
            c1.Name = name;
            c1.CreditNumber = creditNumber;
            c1.Cvc = cvc;
            c1.ExpireDate = date;

            Console.WriteLine("Name: {0}\nExpireDate: {1}", c1.Name, c1.ExpireDate);

            

            Console.ReadLine();
           
        }
    }


    class CreditCard
    {
        public string Name { get; set; }
        public long CreditNumber { private get; set; }
        public int Cvc { private get; set; }
        public string ExpireDate { get; set; }
    }
}

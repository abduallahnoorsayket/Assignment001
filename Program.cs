using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name,add,cnt;
            
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your Address: ");
            add = Console.ReadLine();

            Console.WriteLine("Enter Your Contact:");
            cnt = Console.ReadLine();

          
            Console.WriteLine("\r\nName : " + name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Address: " + add);
            Console.WriteLine("Contact: " + cnt);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> person = new Dictionary<int, string>();

            person.Add(123, "John Smith");
            person.Add(232, "Bill Gates");
            person.Add(346, "Keanu Reeves");
            person.Add(444, "Tim Cook");
            bool flag = false;
            string choose;
            while (true)
            {
                Console.Write("input ID ");
                int id = Convert.ToInt32(Console.ReadLine());
                
                foreach (var p in person)
                {
                    if (p.Key == id)
                    {
                        flag = true;
                        Console.WriteLine(p.Value);
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("ID is incorrect");
                    Console.WriteLine("Try again? (yes/no)");
                    choose = Console.ReadLine();
                    if (choose.ToLower() == "no") break;
                }
                else
                {
                    break;
                }
            }

        }
    }
}

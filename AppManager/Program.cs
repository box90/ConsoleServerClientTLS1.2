using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;

            do
            {
                Console.WriteLine("Insert 1 for Server | 2 for Client: ");
                Console.WriteLine("Insert 9 for Exit: ");

                Int32.TryParse(Console.Read().ToString(), out userChoice);

                switch (userChoice)
                {
                    case 1:
                        ServerApp.Program.Main();
                        break;
                    case 2:
                        ClientApp.Program.Main();
                        break;
                    case 9:
                        break;
                    default: Console.WriteLine($"{userChoice} is not a correct selection!");
                        break;
                }

            } while (userChoice != 9);
           
        }
    }
}

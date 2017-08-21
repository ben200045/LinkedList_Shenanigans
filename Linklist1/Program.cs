using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linklist1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                nodeClass.introSpiel();

                myList list = new myList();
                list.AddSorted(632);
                list.AddSorted(258);
                list.AddSorted(478);
                list.AddSorted(256);
                list.AddSorted(214);
                list.AddSorted(982);
                list.AddSorted(471);
                list.AddSorted(458);
                list.AddSorted(206);
                list.AddSorted(567);

                int userSelection;

                try
                {
                    userSelection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Woah there friend, real inputs only please");
                }
                userSelection = Convert.ToInt32(Console.ReadLine());
                switch (userSelection)
                {
                    case 1:
                        {
                            list.Print();
                            break;
                        }

                    case 2:
                        {
                            int newAdd;
                            Console.WriteLine("Enter the Addition to the LinkedList (The end)");
                            newAdd = Convert.ToInt32(Console.ReadLine());
                            list.AddToEnd(newAdd);
                            break;
                        }

                    case 3:
                        {
                            
                            break;
                        }

                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Woah there friend, that's not an available command, try again");
                            break;
                        }
                }



                Console.ReadLine();
            }
            
            
      

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist1
{
    public class nodeClass
    {

        public static void introSpiel()
        {
            Console.WriteLine("Hi and welcome to the Assessment 1 experience |");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Here in you'll find the required resources to add, delete, find specific data in and view a linklist");
            Console.WriteLine("The Scenario this program will be following will be Scenario 1, Adjacent Neighbours in a street");
            Console.WriteLine("");
            Console.WriteLine("To Continue please select one of the following options");
            Console.WriteLine("1- the list is displayed in forward viewing fashion   --->");
            Console.WriteLine("2- the list is displayed in reverse viewing fashion  <--- ");
            Console.WriteLine("3- ");
        }

        public int data;
        public nodeClass Next;
        public nodeClass Previous;

        public nodeClass(int i)
        {
            data = i;
            Next = null;
            Previous = null;
        }

        public void AddToEnd(int data)
        {
            if (Next == null)
            {
                Next = new nodeClass(data);
            }
            else
            {
                Next.AddToEnd(data);
            }
        }

        

        public void Print()
        {
            Console.Write("|" + data);
            if(Next != null)
            {
                Console.Write("|-->");
                Next.Print();
            }
            else
            {
                Console.WriteLine("|");
            }
        }

        public void AddSorted(int data)
        {
            
            if (Next == null)
            {
                Next = new nodeClass(data);
            }
            else if (data < Next.data)
            {
                nodeClass temp = new nodeClass(data);
                temp.Next = this.Next;
                this.Next = temp;
            }
            else
            {
                Next.AddSorted(data);
            }
        }

        public static void Restart()
        {
            
        }
    }

    public class myList
    {
        public nodeClass headNode;

        public myList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new nodeClass(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddSorted (int data)
        {
            if (headNode == null)
            {
                headNode = new nodeClass(data);
            }
            else if (data < headNode.data)
            {
                AddToBegginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void AddToBegginning(int data)
        {
            if (headNode == null)
            {
                headNode = new nodeClass(data);
            }
            else
            {
                nodeClass temp = new nodeClass(data);
                temp.Next = headNode;
                headNode = temp;
            }
        }

        

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
}

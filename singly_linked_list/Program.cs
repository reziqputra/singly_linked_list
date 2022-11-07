using System;

namespace singly_linked_list
{
    class Node
    {
        public int rollnumber;
        public string name;
        public Node next;
    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }

        public void addnote()
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll Number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nENter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollnumber = rollNo;
            newnode.name = nm;
            if ((START == null) || rollNo <= START.rollnumber)
            {
                if ((START != null) && (rollNo == START.rollnumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo >= current.rollnumber))
            {
                if (rollNo == current.rollnumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = current;
        }


        public bool delnode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while((current != null) && (rollNo != current.rollnumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else return true;
        }
        public void Traverse()
        {
            if(listEmpty())
            {
                Console.WriteLine("\n The record in the list are: ");
            }
            else
            {
                Console.WriteLine("\n  The record in the list are: ");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.rollnumber + "" + currentNode.name + "\n");
                Console.WriteLine("");
            }
        }
        public bool listEmpty()
        {
            if(START == null)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            List obj = new List();
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all the records in the list");
                    Console.WriteLine("4. Search for a second in the list");
                    Console.WriteLine("5. Exit");
                    Console.Write("\nEnter your choice (1-5) : ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch(ch)
                    {
                        case '1':
                            {
                                obj.addnote();
                            }
                            break;
                    }
                }
            }
        }
    }
}
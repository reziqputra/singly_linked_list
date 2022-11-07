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
            START = null; ;
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
            if((START == null) || rollNo <=START.rollnumber)
            {
                if ((START != null)&& (rollNo == START.rollnumber))
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

            while ((current != null)&&(rollNo >= current.rollnumber))
            {
                if(rollNo == current.rollnumber)
                {
                    Console.WriteLine();
                    return ;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = current;
        }
    }

    public bool delnode(int)

    class Program
    {
        static void Main(string[]args)
        {

        }
    }
}
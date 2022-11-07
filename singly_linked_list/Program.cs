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
            Console.Write();
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write();
        }
    }
    class Program
    {
        static void Main(string[]args)
        {

        }
    }
}
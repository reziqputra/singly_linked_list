﻿using System;

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
    }
    class Program
    {
        static void Main(string[]args)
        {

        }
    }
}
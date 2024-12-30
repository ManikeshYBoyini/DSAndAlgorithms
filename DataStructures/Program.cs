using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //string a = "";
            //List
            //LinkedList linkedList = new LinkedList();
            //linkedList.AddNodeSuffix(10);
            //linkedList.AddNodeSuffix(12);
            //linkedList.AddNodeSuffix(13);
            //linkedList.AddNodeSuffix(14);
            //linkedList.AddNodeSuffix(15);
            //linkedList.AddNodeSuffix(16);
            //linkedList.AddNodeSuffix(17);
            //linkedList.AddNodeSuffix(18);
            //linkedList.PrintNodeData();
        }

    }
    

    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

    public class LinkedList
    {
        public LinkedListNode head;
        int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddNodePrefix(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public void AddNodeSuffix(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            head.next = node;
            count++;
        }

        public void PrintNodeData()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }
}

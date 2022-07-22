﻿public class LinkedList
{
    Node head;

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public void InsertFront(int d)
    {
        Node node = new Node(d);
        node.next = head;
        head = node;
    }

    public void InsertRear(int d)
    {
        Node node = new Node(d);
        Node n = head;
        while(n.next!=null)
            n=n.next;
        
        n.next = node;
    }

    public void InsertAtPosition(int d,int position)
    {
        Node node = new Node(d);
        Node n = head;
        if(position<1)
        {
            System.Console.WriteLine("Position cannot be less than 1");
        }
        else if(position == 1)
        {
            node.next = head;
            head = node;
        }
        else
        {
            for(int i=1; i< position-1; i++)
            {
                if(n!=null)
                    n=n.next;
            }
            node.next = n.next;
            n.next = node;
        }
    }
    public void Print()
    {
        Node n= head;
        while(n!=null)
        {
            System.Console.WriteLine(n.data);
            n=n.next;
        }
    }

    public static void Main(string []args)
    {
        LinkedList list = new LinkedList();
        list.head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);

        list.head.next = second;
        second.next = third;

        list.InsertFront(0);
        list.InsertRear(4);
        list.InsertAtPosition(7,6);

        list.Print();
    }
}
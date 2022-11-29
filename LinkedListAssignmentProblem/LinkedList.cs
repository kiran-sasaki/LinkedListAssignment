﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignmentProblem
{
    //Creating a generic class of LinkedList
    public class LinkedList<T>
    {
        public Node<T> head;
        //Add Method For Add Value to Node
        public void Add(T data)
        {
            //Creating object of node
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        //Display Method For Displaying value of The node
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        //Method For Adding value of The node at a particular position
        public void AddingAtParticularPosition(int position, T data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node<T>(data);
                newNode.next = this.head;
                this.head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node<T> node = new Node<T>(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;

                }
                if (position != 1)
                    Console.WriteLine("Position Out of range");
            }
            Console.WriteLine("the Inserted Value is " + data);
        }
    }
}

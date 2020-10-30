﻿using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Data Structure!");
            //Creating object of linked list
            LinkedList linkedList = new LinkedList();
            //adding data
            //linkedList.DataAtEnd(56);
            //linkedList.DataAtEnd(30);
            //linkedList.DataAtEnd(70);
            linkedList.DisplayLinkedList();
            //adding data in front of linkedlist
            linkedList.DataAtFront(70);
            linkedList.DataAtFront(30);
            linkedList.DataAtFront(56);
            //displaying linkedlist
            linkedList.DisplayLinkedList();
            //inserting element in linkedlist
            linkedList.InsertingData(4, 45);
            linkedList.DisplayLinkedList();
            //deleting 1st element from list
            //linkedList.DeleteFirstElement();
            //linkedList.DisplayLinkedList();
            //deleting last element
            //linkedList.DeleteLastElement();
            //linkedList.DisplayLinkedList();
            //searching data in the list
            //linkedList.SearchLinkedList(56);
            int searchdata = 45;
            int index = linkedList.SearchLinkedList(searchdata);
            Console.WriteLine($"{searchdata} is present in the list at {index} position.");
            //inserting element in list using data
            linkedList.InsertingElementWithData(16, 45);
            linkedList.DisplayLinkedList();
            //deleting specific element from the list
            linkedList.DeleteSpecificElementFromList(30);
            linkedList.DisplayLinkedList();

        }
    }
}
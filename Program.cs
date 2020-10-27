﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

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

        }
    }
}
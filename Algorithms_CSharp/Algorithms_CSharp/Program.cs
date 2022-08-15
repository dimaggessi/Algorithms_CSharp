﻿using System.IO;
using System.Diagnostics;
using Algorithms_DataStruct_Lib;

namespace Algorithms_CSharp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            //System.Collections.Generic
            /* [Stack Built-In .NET& General Characteristics]:
             * 
             *  - Built-In stack implementation is based on an array
             *  
             *  [Time Complexity influence]:
             *  
             *  - Peek() - O(1)
             *  - Push() - O(N) when resizing, otherwise O(1)
             *  
             *  - All the search operations such as:
             *      Contains, Find / FindLast - O(N) - have to traverse N elements
             *  
             *  - CopyTo() - O(N)
             *  
             *  - Clear() - O(N) : resets each element in an array to the elements type default value
             *      reference types to null
             *      value types to the default values (boolean to false, int and float to zero, etc)
             * 
             *  - TrimExcess() - O(N)
             *      has effect only if less than 90% capacity is used
             *      otherwise, it won't do anything
             *      (trim capacity to actual length of the stack)
             *  
             */

            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Shoud print out 4:{stack.Peek()}");
            
            stack.Pop();

            Console.WriteLine($"Shoud print out 3:{stack.Peek()}");

            Console.WriteLine("Iterave over stack.");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            /*
            DoublyLinkedList<int> doublyList = new DoublyLinkedList<int>();
            doublyList.AddFirst(1);
            doublyList.AddFirst(2);
            doublyList.AddFirst(3);
            doublyList.AddFirst(4);

            PrintOutDoublyLinkedList(doublyList.Head);

            static void PrintOutDoublyLinkedList(DoublyLinkedNode<int> node)
            {
                while (node != null)
                {
                    Console.Write($"{node.Value} ");
                    node = node.Next;
                }
            }
            */

            /*
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();


            list.RemoveByIndex(1);
            

            PrintOutLinkedList(list.Head);

            static void PrintOutLinkedList(Node<int> node)
            {
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                }
            }
            */

            Console.Read();
        }


        /*
        Node first = new Node() { Value = 5};
        Node second = new Node() { Value = 1};

        first.Next = second;

        Node third = new Node() { Value = 3};
        second.Next = third;
        */





        /*
        //ListDemo.ApiMembers();

        /*Time consumption doesn't grows linearly
        //1Kints Time taken:0:00:00.268237
        //4Kints Time taken:0:00:17.8734063
        //8Kints Time taken:0:02:24.635803

        var ints = In.ReadInts("./Data/1Kints.txt").ToArray();

        //High resolution timer
        var watch = new Stopwatch();
        watch.Start();

        var triplets = ThreeSum.Count(ints);

        watch.Stop();

        /*
        Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
        Console.WriteLine($"Time taken:{watch.Elapsed:g}");
        Console.WriteLine();

        ArrayFundamentals.ArraysDemo();
        Console.WriteLine();
        ArrayFundamentals.TestBasedArray();
        Console.WriteLine();
        ArrayFundamentals.JaggedArray();
        */
    }
}
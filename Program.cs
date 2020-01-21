using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linked List

            //var tempList = new LinkedList<int>();
            //tempList.AddLast(10);
            //tempList.AddLast(20);
            //tempList.AddLast(30);

            //foreach (var i in tempList)
            //{
            //    Console.WriteLine(i);
            //}

            //var list = new LinkedList();
            //list.AddLast(10);
            //list.AddLast(20);
            //list.AddLast(30);

            //list.AddFirst(5);

            //list.DeleteLast();

            //Console.WriteLine(list.IndexOf(45));
            //Console.WriteLine(list.Contains(20));

            #endregion

            #region Stack

            #region Reverse String

            //var str = "abcd";

            //var reversString = new StringReverser();

            //Console.WriteLine(reversString.Reverse(str));

            #endregion

            #region String Balancer

            string input = "((<1> + <2>)) [a]";
            //string input = "(1 + 2)";
            var stringBalancer = new StringBalancer();

            Console.WriteLine(stringBalancer.IsStringBalanced(input));

            #endregion

            #endregion

        }
    }
}

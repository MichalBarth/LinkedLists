using System;

namespace LL00SingleLinkedList
{
    class Program
    {
        static public void WriteList(MyLinkedList<int> ll)
        {
            ListNode<int> current = ll.head;

            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.Next;
            }
        }

        static void Main(string[] args)
        {
            MyLinkedList<int> ll = new MyLinkedList<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(7);
            WriteList(ll);

            Console.WriteLine("\nPočet položek: " + ll.Count);
            Console.WriteLine(ll.Contains(7));
            Console.WriteLine(ll.Contains(69));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

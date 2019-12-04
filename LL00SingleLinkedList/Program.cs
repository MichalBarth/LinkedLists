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
            ll.Add(10);
            ll.Add(20);
            ll.Add(30);
            ll.Add(69);
            ll.AddToStart(1);
            ll.Insert(1, 99);
            ll.SetItem(2, 35);
            ll.Remove(35);
            ll.RemoveAt(3);

            foreach (var l in ll)
            {
                Console.WriteLine(l + " ");
            }

            Console.WriteLine("\nPočet položek: " + ll.Count);
            Console.WriteLine(ll.Contains(7));
            Console.WriteLine(ll.Contains(69));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

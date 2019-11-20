using System;
using System.Collections.Generic;
using System.Text;

namespace LL00SingleLinkedList
{
    class MyLinkedList<T>
    {
        //odkaz na první "node"
        public ListNode<T> head;

        public void Add(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            if (head == null)
            {
                head = node;
            }
            
            else
            {
                //přiřazení prvního prvku
                ListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                //"node" reprezentuje hodnotu a odkaz na další hodnotu v listu
                current.Next = node;
            }
        }

        public int Count
        {
            get
            {
                ListNode<T> current = head;
                int counter = 0;

                while(current != null)
                {
                    counter++;
                    current = current.Next;
                }
                return counter;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public void AddToStart(T item)
        {
            ListNode<T> listNode = new ListNode<T>(item);
            listNode.Next = head;
            head = listNode;
        }

        public bool Contains(T item)
        {
            ListNode<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int Indexof(T item)
        {
            return -1;
        }

        public T GetItem(int index)
        {
            //throw IndexOutOfRangeException
            return default(T);
        }

        public void Insert(int index, T item)
        {

        }
    }
}

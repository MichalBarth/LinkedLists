using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LL00SingleLinkedList
{
    class MyLinkedList<T> : IList<T>
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

        public bool IsReadOnly => throw new NotImplementedException();

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
            ListNode<T> current = head;
            int count = 0;
            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    return count;
                }
                current = current.Next;
                count++;
            }
            return -1;
        }

        public T GetItem(int index)
        {

            return GetNode(index).value;
        }

        public void SetItem(int index, T value)
        {
            GetNode(index).value = value;
        }

        public T this[int index]
        {
            get { return GetItem(index); }
            set { SetItem(index, value); }
        }

        public void Insert(int index, T item)
        {

        }

        public bool Remove(T item)
        {
            ListNode<T> current = head;
            ListNode<T> previous = head;
            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    if (previous == null)
                    {
                        head = head.Next;
                    }

                    else
                    {
                        previous.Next = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            var removed = GetNode(index);
            if (index == 0)
            {
                head = head.Next;
            } else
            {
                var previous = GetNode(index - 1);
                previous.Next = previous.Next.Next;
            }
        }

        protected ListNode<T> GetNode(int index)
        {
            if (index < -1)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }

            ListNode<T> current = head;
            for (int i = 0; i < index; i++ )
            {
                if (current != null)
                {
                    current = current.Next;
                } else
                {
                    break;
                }
            }
            if (current == null)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }

            return current;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyLinkedListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyLinkedListEnumerator<T>(this);
        }
    }
}

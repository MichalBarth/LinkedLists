using System;
using System.Collections.Generic;
using System.Text;

namespace LL00SingleLinkedList
{
    class ListNode<T>
    {
        internal T value;

        //ukazuje na následující prvek
        internal ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            this.value = value;
        }

    }
}

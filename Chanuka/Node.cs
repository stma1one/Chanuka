using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanuka
{
    class Node<T>
    {
        T val;
        Node<T> next;

        public Node( T val)
        {
            this.val = val;
            next = null;
        }
        public Node(T val, Node<T> next)
        {
            this.val = val;
            this.next = next;
        }

        public T GetValue()
        {
            return this.val;
        }
        public Node<T> GetNext()
        {
            return next;
        }
        public bool HasNext()
        {
            return this.next != null;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public void SetValue( T val)
        {
            this.val = val;
        }

        public override string ToString()
        {
            string str = $"[{val}]--->";
            if (next == null)
                str += "null";
            else
                str += next;
            return str;
        }

    }
}

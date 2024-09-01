using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    interface ILinkedListE<T>
    {
        void Push(T item);
        T? Pop();
        void UnShift(T item);
        T? Shift();
    }
    internal class NodeE<T>
    {
        public T Value;
        public NodeE<T>? Next;

        public NodeE(T value)
        {
            Value = value;
            Next = null;
        }
    }

    internal class LinkedListE<T> : ILinkedListE<T>
    {
        private NodeE<T>? _head;
        private NodeE<T>? _tail;
        public int Length { get; set; } = 0;

        public void Push(T item)
        {
            NodeE<T> newNode = new NodeE<T>(item);
            if (_tail != null)
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            else
            {
                _head = _tail = newNode;
            }
            Length++;
        }

        public T? Pop()
        {
            if (_head == null)
            {
                return default(T);
            }

            else if (_head == _tail)
            {
                T valuee = _head.Value;
                _head = _tail = null;
                return valuee;
            }
            
            NodeE<T> current = _head;
            while (current.Next != _tail)
            {
                current = current.Next;
            }

            T value = _tail.Value;
            _tail = current;
            _tail.Next = null;
            Length--;
            return value;
        }


        public T? Shift()
        {
            if (Length == 0)
            {
                return default( T);
            }

            T value = _head.Value;
            _head = _head.Next;
            if (_head == null)
            {
                _tail = null;
            }
            Length--;
            return value;
        }

        public void UnShift(T item)
        {
            NodeE<T> newNode = new NodeE<T>(item);
            if (Length == 0)
            {
                _head = _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }
            Length++;
        }

        public override string ToString()
        {
            if (Length == 0)
            {
                return string.Empty;
            }

            NodeE<T>? current = _head;
            string res = "";
            while (current != null)
            {
                res += $"{ current.Value}, ";
                current = current.Next;
            }
            return res;
        }
    }
}

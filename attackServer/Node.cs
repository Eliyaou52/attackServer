using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Node<T>
    {
        private T _value;
        private Node<T> _next;
        public Node() { }
        public Node(T value)
        { 
            this.SetValue(value);
            this.SetNext(null);
        }

        public Node(T value, Node<T> next) 
        {
            this.SetValue(value);
            this.SetNext(next);
        }
        public void SetValue(T value)
        {
            this._value = value;
        }

        public T GetValue() 
        {
            return this._value; 
        }
        public void SetNext(Node<T> next)
        {
            this._next = next;
        }

        public Node<T> GetNext()
        {
            return this._next;
        }


        public override string ToString()
        {
            if (this._next != null)
                return $"Node value is: {this._value} Has {this._next}.";
            else return $"Node value is: {this._value} Has no _next.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Node
    {
        private int? _value;
        private Node _next;
        public Node() 
        { 
            this.SetValue(null);
            this.SetNext(null);
        }
        public Node(int value)
        { 
            this._value = value;
            this.SetNext(null);
        }

        public Node(int value, Node next) 
        {
            this._value = value;
            this._next = next = null;
        }
        public void SetValue(int? value)
        {
            this._value = value;
        }

        public int? GetValue() 
        {
            return this._value; 
        }
        public void SetNext(Node next)
        {
            this._next = next;
        }

        public Node GetNext()
        {
            return this._next;
        }


        public override string ToString()
        {
            if (this._next != null)
                return $"Node value is: {this._value}. Has {this._next}";
            else return $"Node value is: {this._value}. Has no _next";
        }
    }
}

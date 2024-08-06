using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Queue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;
        public Queue()
        {
            this.setHead(null);
            this.setTail(null);
            this.setCount(0);
        }

        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.getTail() != null) 
            {
                Node<T> tail = this.getTail();
                tail.SetNext(newNode);
            }
            if (this.getHead() == null)
            {
                this.setHead(newNode);
            }
            this.setTail(newNode);
            this.setCount(this.getCount() + 1);
        }

        public T Dequeue()
        {
            if(this.IsEmpty()) throw new Exception("Queue is empty. ") ;
            T value = this.getHead().GetValue();
            this.setHead(this.getHead().GetNext());
            if (this.getHead() == null) 
            {
                this.setTail(null);
            }
            this.setCount(this.getCount() - 1);
            return value;
        }

        public bool IsEmpty()
        {
            return this.getHead() == null;
        }

        public void setHead(Node<T> head)
        {
            this._head = head;
        }
        public void setTail(Node<T> tail)
        {
            this._tail = tail;
        }
        public void setCount(int count)
        {
            this._count = count;
        }
        public Node<T> getHead()
        {
            return this._head;
        }
        public Node<T> getTail()
        {
            return this._tail;
        }
        public int getCount()
        {
            return this._count;
        }
    }
}

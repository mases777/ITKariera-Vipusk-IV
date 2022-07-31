using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }
        public Node(T Value)
        {
            this.Value = Value;
            this.Next = null;
            this.Prev = null;
        }
    }

    public class Deque<T> : IList<T>
    {
        private const int defaultCapacity = 16;
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Deque() : this(defaultCapacity)
        {
            this.Capacity = defaultCapacity;
        }
        public Deque(int capacity)
        {
            this.Capacity = capacity;
        }


        public void AddBack(T item)
        {
            if (Count == 0)
            {
                this.Head = this.Tail = new Node<T>(item);
            }
            else
            {
                var newone = new Node<T>(item);
                newone.Prev = this.Tail;
                this.Tail.Next = newone;
                this.Tail = newone;
            }
            this.Count++;
        }

        private void GrowBack()
        {
            throw new NotImplementedException();
        }



        public void AddFront(T item)
        {
            if (Count == 0)
            {
                this.Head = this.Tail = new Node<T>(item);
            }
            else
            {
                var newone = new Node<T>(item);
                newone.Next = this.Head;
                this.Head.Prev = newone;
                this.Head = newone;
            }
            this.Count++;
        }
        private void GrowFront()
        {
            throw new NotImplementedException();
        }

        public T GetFront()
        {
            return this.Head.Value;
        }

        public T GetBack()
        {
            return this.Tail.Value;
        }

        public T RemoveBack()
        {
            var item = this.Tail.Value;
            this.Tail = this.Tail.Prev;
            this.Tail.Next = null;            
            this.Count--;
            return item;
        }

        public T RemoveFront()
        {
            var item = this.Head.Value;
            this.Head.Prev = null;
            this.Head = this.Head.Next;
            this.Count--;
            return item;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

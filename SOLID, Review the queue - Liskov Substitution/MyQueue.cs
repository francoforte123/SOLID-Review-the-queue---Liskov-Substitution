using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Liskov_Substitution
{
    public abstract class MyQueue<T>
    {
        public T[] array = new T[10];
        public int firstElement;

        public abstract void Queue(T value);
        public abstract T Dequeue();
        public abstract T Peek();
    }
}

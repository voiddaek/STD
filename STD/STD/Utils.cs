using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD
{
    public static class CircularLinkedList
    {
        public static LinkedListNode<Vector2> NextOrFirst(this LinkedListNode<Vector2> current)
        {
            if (current.Next == null)
                return current.List.First;
            return current.Next;
        }

        public static LinkedListNode<Vector2> PreviousOrLast(this LinkedListNode<Vector2> current)
        {
            if (current.Previous == null)
                return current.List.Last;
            return current.Previous;
        }
    }

    public class Wrapper<T>
    {
        public T Value;

        public Wrapper(T value)
        {
            Value = value;
        }
    }
}

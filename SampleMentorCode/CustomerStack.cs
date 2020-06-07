using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SampleMentorCode
{
    class CustomerStack
    {
        StackByArray sya = new StackByArray(10);
        public CustomerStack()
        {
        }
    }

    class StackByArray
    {
        private int[] InternalArray = null;
        public int Count = -1;
        public StackByArray(int capacity)
        {
            if (capacity <= 0)
                throw new Exception("Capacity less than or equal to zero.");
            InternalArray = new int[capacity];
        }
        public void Push(int i)
        {
            if (Count >= InternalArray.Length)
                throw new Exception("Stack overflow.");
            Count++;
            InternalArray[Count] = i;
        }
        public int Peek()
        {
            if (Count < 0)
                throw new Exception("Stack underflow.");
            return InternalArray[Count];
        }
        public int Pop()
        {
            int i = Peek();
            Count--;
            return i;
        }
    }

    class StackByList
    {
        private List<int> InternalList = null;
        public StackByList()
        {
            InternalList = new List<int>();
        }
        public void Push(int i)
        {
            InternalList.Add(i);
        }
        public int Peek()
        {
            if (InternalList.Count == 0)
                throw new Exception("Stack underflow.");
            return InternalList[InternalList.Count - 1];
        }

        public int Pop()
        {
            int i = Peek();
            InternalList.RemoveAt(InternalList.Count - 1);
            return i;
        }
    }
}

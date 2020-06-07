using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMentorCode
{
    class BST
    {
        public int Value;
        public BST Left = null;
        public BST Right = null;
        public BST(int i)
        {
            Value = i;
        }
        public void Insert(int i)
        {
            if (i <= Value)
            {
                if (Left == null)
                    Left = new BST(i);
                else
                    Left.Insert(i);
            }
            else
            {
                if (Right == null)
                    Right = new BST(i);
                else
                    Right.Insert(i);
            }
        }
        public void PreOrder()
        {
            Console.WriteLine(Value);
            if (Left != null)
                Left.PreOrder();
            if (Right != null)
                Right.PreOrder();
        }
        public void InOrder()
        {
            if (Left != null)
                Left.InOrder();
            Console.WriteLine(Value);
            if (Right != null)
                Right.InOrder();
        }
        public void PostOrder()
        {
            if (Left != null)
                Left.PostOrder();
            if (Right != null)
                Right.PostOrder();
            Console.WriteLine(Value);
        }
    }
}

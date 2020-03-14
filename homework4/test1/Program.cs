using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> i = head; i != null; i = i.Next)
            {
                action(i.Data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(5);
            intList.Add(10);
            intList.Add(8);
            //打印链表
            Action<int> print = delegate (int i)
            {
                Console.WriteLine(i);
            };
            intList.ForEach(print);
            //求和
            int sum = 0;
            intList.ForEach(m => sum += m);
            Console.WriteLine("链表元素和为：" + sum);
            //求最大值
            int max = 0;
            Action<int> getMax = delegate (int i)
            {
                if (i > max)
                    max = i;
            };
            intList.ForEach(getMax);
            Console.WriteLine("链表最大值为：" + max);
            //求最小值
            int min = max;
            Action<int> getMin = delegate (int i)
            {
                if (i < min)
                    min = i;
            };
            intList.ForEach(getMin);
            Console.WriteLine("链表最小值为：" + min);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlistnoClass
{
    public class MyLinkedList
    {
        public Nodes HeadNode;
        public Nodes CurrentNode;
        private int ListSize;

        public int LinkedListSize
        {
            get
            {
                return ListSize;
            }
        }

        public MyLinkedList()
        {
            ListSize = 0;
            HeadNode = null;
        }

        public void AddNode(object content)
        {
            ListSize++;
            Nodes node = new Nodes(content);
            if (HeadNode==null)
            {
                HeadNode = node;
            }
            else
            {
                CurrentNode.Next = node;
            }

            CurrentNode = node;
        }

        public bool DeleteNode(int index)
        {
            if (index == 1)
            {
                Nodes tempNode = HeadNode.Next;
                HeadNode = tempNode;
            }
            if (index > 1&&index<ListSize)
            {
                Nodes tempnode = HeadNode;
                Nodes Lastnode = null;
                int count = 0;
                while (tempnode!=null)
                {
                    if (count == index - 1)
                    {
                        Lastnode.Next = tempnode.Next;
                        return true;
                    }

                    count++;
                    Lastnode = tempnode;
                    tempnode = tempnode.Next;
                }
            }

            return false;
        }

        public void ShowList()
        {
            Nodes tempNode = HeadNode;
            while (tempNode!=null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }
    }
}

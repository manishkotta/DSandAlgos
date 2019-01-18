using System;
namespace DSandAlgos
{
    public class CloneLinkedList
    {

        public class Node
        {
            public int _x;
            public Node random, next;
            public Node(int x)
            {
                _x = x;
                random = next = null;
            }
        }

        public static void Main(string[] args)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            node1.random = node3;
            node2.random = node5;
            node3.random = node4;
            node4.random = node1;
            node5.random = node2;

            var obj = new CloneLinkedList();
            obj.Clone(node1);

            Console.ReadLine();
        }

        public void PrintNodes(Node head)
        {
            Console.WriteLine("", "");
            while (head != null)
            {
                Console.WriteLine($"Random:{head.random?._x}, Current:{head._x}, Next : {head.next?._x}");
                head = head.next;
            }
        }

        public Node Clone(Node head)
        {
            Node current = head, temp, copy;
            // copy each node and insert it between current and next node
            while (current != null)
            {
                temp = current.next;
                current.next = new Node(current._x);
                current.next.next = temp;
                current = temp;
            }
           
            current = head;

            // Adjust the random pointers. current next random = current random next
            while (current != null)
            {
                current.next.random = current.random != null ? current.random.next : current.random;
                current = current.next.next;
            }

            current = head;
            copy = head.next;
            temp = copy;
            // Seperate linked lists
            while (current != null)
            {
                current.next = current.next != null ? current.next.next : current.next;
                copy.next = copy.next != null ? copy.next.next : copy.next;
                current = current.next;
                copy = copy.next;
            }

            PrintNodes(head);
            PrintNodes(temp);
            return temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedLists
    {
        public Node<int> head;
        /// <summary>
        /// This Method is for Adding Elements to the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node<int> node = new Node<int>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<int> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// <summary>
        /// This Method is To Display the Elements In The LinkedList
        /// </summary>
        public void Display()
        {
            Node<int> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        /// <summary>
        /// This Method is For Adding Elements In Reverse Order Into LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddInReverseOrder(int data)
        {
            Node<int> newNode = new Node<int>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<int> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }

        /// <summary>
        /// This Method is For Appending Elements Into LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            Node<int> node = new Node<int>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<int> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// <summary>
        /// This Method is For Searching Index/Position of the Element
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Search(int value)
        {
            Node<int> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }

        /// <summary>
        /// This Method Is For Inserting Elements At Particular Position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node<int> InsertAtParticularPosition(int position, int data)
        {
            Node<int> newestNode = new Node<int>(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node<int> prev = null;
            Node<int> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }

        /// <summary>
        /// This Method is For Removing First Element
        /// </summary>
        /// <returns></returns>
        public Node<int> RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        /// <summary>
        /// This Method is For Removing Last Element
        /// </summary>
        /// <returns></returns>
        public Node<int> RemoveLastNode()
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Node<int> newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        /// <summary>
        /// This Method Deletes Particular Element
        /// </summary>
        /// <param name="data"></param>
        public void DeleteParticularElement(int data)
        {
            Node<int> temp = head;
            Node<int> prev = null;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            if (temp !=null && temp.data == data)
            {
                head = temp.next;
            }
            while (temp!=null && temp.data != data)  
            {                                        
                prev = temp;                         
                temp = temp.next;                    
            }
            prev.next = temp.next;                   
        }

        /// <summary>
        /// This Method Is for Finding Size Of LinkedList
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node<int> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                return count;
            }
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }


    }
}

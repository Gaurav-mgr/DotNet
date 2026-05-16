using c = System.Console;
using System.Collections.Generic;

namespace Lab6
{
    internal class GenericsEx
    {
        public static void Main()
        {

            //list
            List<int> list = new List<int>();
            list.Add(1010);
            list.Add(2020);
            list.Add(2934);
            list.Insert(1, 59);
            c.Write("Total elements in the list: "+list.Count);
            c.Write("\nList ELements are: ");
            foreach(int data in list)
            {
                c.Write(data+" ");
            }
            list.Remove(2020);
            list.RemoveAt(0);
            c.Write("\nTotal elements in the list after removing: "+list.Count);

            //stack
            Stack<int> stack = new Stack<int>();
            stack.Push(324);
            stack.Push(242);
            stack.Push(2324);
            c.Write("\n\nStack Elements are: ");
            foreach (int data in stack)
            {
                c.Write(data + " ");
            }
            c.WriteLine("\nTop element in the stack: " + stack.Peek());
            stack.Pop();
            c.WriteLine("Top element in the stack after pop: " + stack.Peek());
            c.WriteLine("Stack contains 242? "+stack.Contains(242));

            //Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(234);
            queue.Enqueue(432);
            queue.Enqueue(543);
            c.Write("\n\nQueue Elements are: ");
            foreach (int data in queue)
            {
                c.Write(data + " ");
            }
            c.WriteLine("\nFront element in the queue: " + queue.Peek());
            queue.Dequeue();
            c.WriteLine("Front element in the queue after dequeue: " + queue.Peek());
            c.WriteLine("Queue contains 432? " + queue.Contains(432));

            //LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(123);
            linkedList.AddLast(456);
            linkedList.AddBefore(linkedList.First, 789);
            c.Write("\n\nLinkedList Elements are: ");
            foreach (int data in linkedList)
            {
                c.Write(data + " ");
            }
            c.WriteLine($"\nFirst Element in the linked list: {linkedList.First.Value}\nLast E lement in the linked list: {linkedList.Last.Value}");
            linkedList.RemoveFirst();
            c.WriteLine($"First element in the linked list after removing first: {linkedList.First.Value}");
            c.WriteLine("Linked List contains 456? " + linkedList.Find(456).Value);

            //Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);
            c.Write("\n\nDictionary ELements are: ");
            foreach (var data in dictionary)
            {
                c.Write(data.Key+"->"+data.Value+", ");
            }
            c.WriteLine("\nTotal elements in the dictionary: " + dictionary.Count);
            c.WriteLine("Value for key 'Two': " + dictionary["Two"]);
            dictionary.Remove("Two");
            c.WriteLine("Total elements in the dictionary after removing: " + dictionary.Count);

            c.ReadLine();
        }
    }
}

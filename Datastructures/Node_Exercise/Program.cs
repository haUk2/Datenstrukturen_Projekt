using Datastructures;
using System.Data.Common;
namespace GenerischeKlassen
{
    class Program
    {
        public static void Main(String[] args)
        {
            Datastructures.SingleLinkedList linkedList = new Datastructures.SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(4);
            linkedList.insertLast(4);
            linkedList.insertLast(6);
            linkedList.insertLast(5);
            //linkedList.InsertAfter(9, 2);
            //linkedList.insert_First(7);
            //linkedList.DeleteNode(3);
            //linkedList.GetNode(4);
            //linkedList.SwitchNode(2, 4);
            //linkedList.SwitchNode2(new Node(2, null), new Node(4, null));
            Console.WriteLine("Linked List before Sorting..");
            linkedList.printList();
            //Console.WriteLine("\nLinkedList After sorting");
            //ISort.insertionSort(linkedList.head);
            Console.WriteLine("\nLinkedList After sorting reverse");
            //linkedList.insertionSortInverse(linkedList.head);
            linkedList.printList();
            //Console.WriteLine(linkedList.GetNode(4));
        }
    }
}
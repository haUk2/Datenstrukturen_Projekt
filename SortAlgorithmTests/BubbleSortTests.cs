using Common;
using GenericList;
using NUnit.Framework;
using Sorting;

namespace SortAlgorithmTests
{
    public class BubbleSortTests
    {
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        Node node4 = new Node(4);
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void TestSLLBubbleSortStrategy_fewNodes_NodesAreSorted()
        {
            var myLL = new SingleLinkedList();
            myLL.SetSortStrategy(new BubbleSort());
            myLL.InsertLast(node4);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node1);
            myLL.Sort();
            Assert.AreEqual(myLL.ToString(), "| 1 | 2 | 3 | 4 |");
        }


        [Test]
        public void TestSLLBubbleSortStrategy_NodesWithEqualData_NodesAreSorted()
        {
            var myLL = new SingleLinkedList();
            myLL.SetSortStrategy(new BubbleSort());
            myLL.InsertLast(new Node(4));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(3));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(4));
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(3));

            myLL.Sort();
            Assert.AreEqual(myLL.ToString(), "| 1 | 2 | 2 | 2 | 2 | 3 | 3 | 4 | 4 |");
        }

        [Test]
        public void TestSLLBubbleSortStrategyDesc_NodesWithEqualData_NodesAreSorted()
        {
            var myLL = new SingleLinkedList();
            myLL.SetSortStrategy(new BubbleSort());
            myLL.InsertLast(new Node(4));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(3));
            myLL.InsertLast(new Node(2));
            myLL.InsertLast(new Node(4));
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(3));

            myLL.SortDesc();
            Assert.AreEqual(myLL.ToString(), "| 4 | 4 | 3 | 3 | 2 | 2 | 2 | 2 | 1 |");
        }
    }
}
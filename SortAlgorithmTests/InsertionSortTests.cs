using Common;
using GenericList;
using NUnit.Framework;
using Sorting;

namespace SortAlgorithmTests
{
    public class InsertionSortTests
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
        public void TestSLLInsertionSortRevertedStrategy_fewNodes_NodesAreSorted()
        {
            var myLL = new SingleLinkedList();
            myLL.SetSortStrategy(new InsertionSortReverted());
            myLL.InsertLast(node4);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node1);
            myLL.Sort();
            Assert.AreEqual(myLL.ToString(), "| 4 | 3 | 2 | 1 |");
        }
        [Test]
        public void TestSLLInsertionSortStrategy_fewNodes_NodesAreSorted()
        {
            var myLL = new SingleLinkedList();
            myLL.SetSortStrategy(new InsertionSort());
            myLL.InsertLast(node4);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node1);
            myLL.Sort();
            Assert.AreEqual(myLL.ToString(), "| 1 | 2 | 3 | 4 |");
        }
    }
}
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericList;
using Common;

namespace TestProject1
{
    public class SingleLinkedListTest
    {
        SingleLinkedList mySLL = new SingleLinkedList();
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        Node node4 = new Node(4);
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestSLLCount_AddItems_ReturnsCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(1));
            myLL.InsertLast(new Node(1));  
            Assert.AreEqual(4, myLL.count());
        }

        [Test]
        public void TestSLLSwitchNodes_NodesExist_SwitchNodes()
        {
            var myLL = new SingleLinkedList();
            myLL.InsertLast(node1);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node4);
            Assert.AreEqual(4, myLL.count());
            myLL.SwitchNode(new Node(2), new Node(3));
            Assert.AreEqual(myLL.ToString(), "| 1 | 3 | 2 | 4 |");
        }

        [Test]
        public void TestSLLSwitchNodes_SecondNodeDoesNotExist_NoChangeAtAll()
        {
            var myLL = new SingleLinkedList();

            myLL.InsertLast(node1);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node4);
            Assert.AreEqual(4, myLL.count());
            myLL.SwitchNode(new Node(2), new Node(42));
            Assert.AreEqual(myLL.ToString(), "| 1 | 2 | 3 | 4 |");
        }

        [Test]
        public void TestSLLSwitchNodes_FirstNodeDoesNotExist_NoChangeAtAll()
        {
            var myLL = new SingleLinkedList();

            myLL.InsertLast(node1);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node4);
            Assert.AreEqual(4, myLL.count());
            myLL.SwitchNode(new Node(42), new Node(3));
            Assert.AreEqual(myLL.ToString(), "| 1 | 2 | 3 | 4 |");

        }

        [Test]
        public void TestSLLSwitchNodes_NoNodeDoesExist_DontChangeAnything()
        {
            var myLL = new SingleLinkedList();

            myLL.InsertLast(node1);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node4);
            Assert.AreEqual(4, myLL.count());
            myLL.SwitchNode(new Node(42), new Node(24));
            Assert.AreEqual(myLL.ToString(), "| 1 | 2 | 3 | 4 |");
        }

        [Test]
        public void TestSLLRemoveFirst_NextExists_FirstIsNext()
        {
            var myLL = new SingleLinkedList();

            myLL.InsertLast(node1);
            myLL.InsertLast(node2);
            myLL.InsertLast(node3);
            myLL.InsertLast(node4);
            myLL.RemoveFirstElement();
            Assert.AreEqual(myLL.ToString(), "| 2 | 3 | 4 |");
        }

        [Test]
        public void TestSLLRemoveFirst_NextDoesNotExist_FirstGetsNull()
        {
            var myLL = new SingleLinkedList();

            myLL.InsertLast(node1);
            myLL.RemoveFirstElement();
            Assert.AreEqual(myLL.ToString(), "No elements in List");
        }

        [Test]
        public void TestSLLRemoveFirst_NoElements_FirstGetsNull()
        {
            var myLL = new SingleLinkedList();

            myLL.InsertLast(node1);
            myLL.RemoveFirstElement();
            Assert.AreEqual(myLL.ToString(), "No elements in List");
        }
    }
}

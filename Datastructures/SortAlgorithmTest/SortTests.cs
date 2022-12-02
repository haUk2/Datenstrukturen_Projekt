using Common;
using Datastructures;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SortAlgorithmTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStrategyPatternInsertionSort_InsertNumbers1865_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new InsertionSort());
            linkedList.insertLast(1);
            linkedList.insertLast(8);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 1);
            Assert.AreEqual(linkedList.head.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.next.data, 8);
        }

        [Test]
        public void TestInsertionSort_InsertOneNumber_ReturnReverseOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new InsertionSort());
            linkedList.insertLast(1);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 1);
        }

        [Test]
        public void TestInsertionSortInverse_InsertSameNumbers1665_ReturnReverseOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new InsertionSortInverse());
            linkedList.insertLast(1);
            linkedList.insertLast(6);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 6);
            Assert.AreEqual(linkedList.head.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.next.data, 1);
        }

        [Test]
        public void TestStrategyPatternBubbleSort_InsertNumbers1865_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new BubbleSort());
            linkedList.insertLast(1);
            linkedList.insertLast(8);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 1);
            Assert.AreEqual(linkedList.head.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.next.data, 8);
        }
    }
}
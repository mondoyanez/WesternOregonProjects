using System;
using CircularQueue.Lib;
using NUnit.Framework;

namespace CircularQueue.Test
{
    public class CircularQueueTests
    {
        private CircularQueue<int>? _queue;
        private CircularQueue<char>? _queue2;

        [SetUp]
        public void Setup()
        {
            _queue = new CircularQueue<int>(5);
            _queue2 = new CircularQueue<char>(5);
        }

        [Test]
        public void TestIsEmptyShouldReturnTrueAfterNewingUp()
        {
            // Arrange

            // Act 
            var isEmpty = _queue?.IsEmpty;

            // Assert
            Assert.True(isEmpty);
        }

        [Test]
        public void TestIsFullShouldReturnFalseAfterNewingUp()
        {
            // Arrange

            // Act 
            var isFull = _queue?.IsFull;

            // Assert
            Assert.False(isFull);
        }

        [Test]
        public void TestCountShouldReturnZeroForAnEmptyQueue()
        {
            // Arrange

            // Act 
            var count = _queue?.Count;

            // Assert
            Assert.AreEqual(0, count);
        }

        [Test]
        public void TestEnqueueCountShouldBeOneAfterASingleEnqueue()
        {
            // Arrange

            // Act 
            _queue?.Enqueue(1);

            // Assert
            Assert.AreEqual(1, _queue?.Count);
        }

        [Test]
        public void TestFrontShouldReturnOneAfterEnqueueingOne()
        {
            // Arrange

            // Act 
            _queue?.Enqueue(1);

            // Assert
            Assert.AreEqual(1, _queue?.Front);
        }

        [Test]
        public void TestBackShouldReturnThreeAfterEnqueueingThreeItems()
        {
            // Arrange

            // Act 
            for (var i = 10; i < 13; ++i) _queue?.Enqueue(i);

            // Assert
            Assert.AreEqual(12, _queue?.Back);
        }

        [Test]
        public void TestBackShouldReturnZAfterEnqueueingThreeItems()
        {
            // Arrange

            // Act 
            _queue2?.Enqueue('X');
            _queue2?.Enqueue('Y');
            _queue2?.Enqueue('Z');

            // Assert
            Assert.AreEqual('Z', _queue2?.Back);
        }

        [Test]
        public void TestEnqueueShouldThrowExceptionWhenQueueIsFull()
        {
            int i;
            for (i = 0; i < 5; ++i) _queue?.Enqueue(i);

            Assert.Throws<Exception>(() =>
            {
                _queue?.Enqueue(i);
            });

        }

        [Test]
        public void TestDequeueProperValueDequeuedInt()
        {
            for (var i = 10; i < 15; ++i)
            {
                _queue?.Enqueue(i);
            }

            var valueDequeued = _queue?.Dequeue();

            Assert.AreEqual(10, valueDequeued);
        }

        [Test]
        public void TestDequeueValueRemovedInt()
        {
            for (var i = 10; i < 15; ++i)
            {
                _queue?.Enqueue(i);
            }

            _queue?.Dequeue();

            Assert.AreEqual(4, _queue?.Count);
        }

        [Test]
        public void TestDequeueProperValueDequeuedChar()
        {
            _queue2?.Enqueue('A');
            _queue2?.Enqueue('B');
            _queue2?.Enqueue('C');

            var valueDequeued = _queue2?.Dequeue();

            Assert.AreEqual('A', valueDequeued);
        }

        [Test]
        public void TestDequeueValueRemovedChar()
        {
            _queue2?.Enqueue('A');
            _queue2?.Enqueue('B');
            _queue2?.Enqueue('C');

            _queue2?.Dequeue();

            Assert.AreEqual(2, _queue2?.Count);
        }

        [Test]
        public void TestDequeueShouldThrowExceptionIfArrayEmpty()
        {
            Assert.Throws<Exception>(() =>
            {
                _queue?.Dequeue();
            });
        }

        [Test]
        public void TestFrontShouldThrowExceptionIfArrayEmpty()
        {
            Assert.Throws<Exception>(() =>
            {
                var front = _queue?.Front;
            });
        }

        [Test]
        public void TestBackShouldThrowExceptionIfArrayEmpty()
        {
            Assert.Throws<Exception>(() =>
            {
                var back = _queue?.Back;
            });
        }

        [Test]
        public void TestResizeProperlyResized()
        {
            _queue?.Resize(10);
            for (int i = 1; i < 11; i++) _queue?.Enqueue(i);

            Assert.AreEqual(10, _queue?.Count);
        }

        [Test]
        public void TestResizeDataIntegrityRetained()
        {
            CircularQueue<int>? originalQueue = new CircularQueue<int>(5);

            for (int i = 1; i < 6; i++)
            {
                _queue?.Enqueue(i);
                originalQueue.Enqueue(i);
            }
            
            _queue?.Resize(10);

            Assert.AreEqual(originalQueue?.Count, _queue?.Count);

        }

        [Test]
        public void TestResizeDataIntegrityRetainedTruncationOccursHowever()
        {
            CircularQueue<int>? originalQueue = new CircularQueue<int>(5);
        
            for (int i = 1; i < 6; i++)
            {
                _queue?.Enqueue(i);
                originalQueue.Enqueue(i);
            }
        
            _queue?.Resize(3);
        
            Assert.AreEqual(originalQueue?.Count, _queue?.Count);
        
        }
    }
}
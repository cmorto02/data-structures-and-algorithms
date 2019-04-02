using System;
using Xunit;
using stacksAndQueues.classes;
using stacksAndQueues;

namespace StackAndQueueTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ICanPushOntoAStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);

            Assert.Equal(5, stack.Top.Value);
        }
        [Fact]
        public void ICanPushMultipleNodesOntoAStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(6);

            Assert.Equal(5, stack.Top.Next.Value);
        }
        [Fact]
        public void ICanPopOffTheStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(6);
            stack.Pop();

            Assert.Equal(5, stack.Top.Value);
        }
        [Fact]
        public void ICanEmptyTheStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(6);
            stack.Pop();
            stack.Pop();

            Assert.Null(stack.Top);
        }
        [Fact]
        public void ICanPeekTheNextItemOnTheStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(6);
            int peeked = stack.Peek();

            Assert.Equal(6, peeked);
        }
        [Fact]
        public void ICanHaveAnEmptyStack()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Null(stack.Top);
        }
        [Fact]
        public void ICanEnqueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);

            Assert.Equal(4, queue.Front.Value);
        }
        [Fact]
        public void ICanEnqueueMultiple()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(7);

            Assert.Equal(7, queue.Rear.Value);
        }
        [Fact]
        public void ICanDequeue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(7);
            queue.Dequeue();

            Assert.Equal(7, queue.Front.Value);
        }
        [Fact]
        public void ICanDequeueUntilEmpty()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(7);
            queue.Dequeue();
            queue.Dequeue();

            Assert.Null(queue.Front);
        }
        [Fact]
        public void ICanPeekIntoAQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(7);
            int result = queue.Peek();

            Assert.Equal(4, result);
        }
        [Fact]
        public void ICanInstantiateAnEmptyQueue()
        {
            Queue<int> queue = new Queue<int>();
            
            Assert.Null(queue.Front);
        }
    }
}

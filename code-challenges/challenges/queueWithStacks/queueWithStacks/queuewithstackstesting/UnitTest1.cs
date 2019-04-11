using System;
using Xunit;
using queueWithStacks;

namespace queuewithstackstesting
{
    public class UnitTest1
    {
        [Fact]
        public void IDoFirstInFirstOut()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(6);
            test.Enqueue(7);

            Assert.Equal(6, test.Dequeue());
        }
        [Fact]
        public void IDoNotDoFirstInLastOut()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(6);
            test.Enqueue(7);

            Assert.NotEqual(7, test.Dequeue());
        }
    }
}

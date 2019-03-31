using System;
using Xunit;
using LLMerge;
using SinglyLinkedList.classes;

namespace MergeTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ICanMergeTwoLinkedLists()
        {
            LList ALink = new LList();
            ALink.Insert(8);
            ALink.Insert(6);
            ALink.Insert(4);

            LList BLink = new LList();
            BLink.Insert(9);
            BLink.Insert(7);
            BLink.Insert(5);

            LList list = LLMerge.Program.MergeLists(ALink, BLink);
            int[] result = list.Print();
            int[] test = new int[] { 4, 5, 6, 7, 8, 9 };

            Assert.Equal(test, result);
        }
        [Fact]
        public void ICanMergeAnEmptyList()
        {
            LList ALink = new LList();

            LList BLink = new LList();
            BLink.Insert(9);
            BLink.Insert(7);
            BLink.Insert(5);

            LList list = LLMerge.Program.MergeLists(ALink, BLink);
            int[] result = list.Print();
            int[] test = new int[] { 5, 7, 9 };

            Assert.Equal(test, result);
        }
        [Fact]
        public void ICanNotMergeInNull()
        {
            LList ALink = null;

            LList BLink = new LList();
            BLink.Insert(9);
            BLink.Insert(7);
            BLink.Insert(5);

            LList list = LLMerge.Program.MergeLists(ALink, BLink);

            Assert.Null(list);
        }
    }
}

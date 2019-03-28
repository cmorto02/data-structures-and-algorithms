using System;
using Xunit;
using SinglyLinkedList.classes;

namespace LinkedListTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ICanMergeTwoLists()
        {
            LList ALink = new LList();
            ALink.Insert(4);
            ALink.Insert(6);
            ALink.Insert(8);

            LList BLink = new LList();
            BLink.Insert(5);
            BLink.Insert(7);
            BLink.Insert(9);

        }

        
    }
}

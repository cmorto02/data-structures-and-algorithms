using System;
using Xunit;
using SinglyLinkedList.classes;

namespace LinkedListTesting
{
    public class UnitTest1
    {
        [Fact]
        public void ICanMakeAnEmptyList()
        {
            //Arrange and act
            LList ALink = new LList();

            //Assert
            Assert.True(ALink.Head == null);
        }

        [Fact]
        public void ICanInsertIntoTheList()
        {
            //Arrange and act
            LList ALink = new LList();
            ALink.Insert(4);

            //Assert
            Assert.True(ALink.Head.Value == 4);
        }
        [Fact]
        public void TheHeadPointsToTheNext()
        {
            //Arrange and act
            LList ALink = new LList();
            ALink.Insert(5);
            ALink.Insert(4);

            //Assert
            Assert.True(ALink.Head.Next.Value == 5);
        }
        [Fact]
        public void ICanInsertMultiple()
        {
            //Arrange and act
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Assert
            Assert.True(ALink.Head.Next.Next.Value == 6);
        }
        [Fact]
        public void ICanSeeIfAValueExists()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            bool truth = ALink.Includes(5);

            //Assert
            Assert.True(truth);
        }
        [Fact]
        public void ICanSeeIfAValueDoesntExist()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            bool truth = ALink.Includes(7);

            //Assert
            Assert.False(truth);
        }
        [Fact]
        public void ICanReturnAListOfNodeValues()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);
            int[] testValues = new int[] { 4, 5, 6 };

            //Act
            int[] values = ALink.Print();

            //Assert
            Assert.Equal(testValues, values);
        }
        [Fact]
        public void ICanAddANodeToTheEnd()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);
            int[] testValues = new int[] { 4, 5, 6, 7 };

            //Act
            ALink.Append(7);
            int[] values = ALink.Print();

            //Assert
            Assert.Equal(testValues, values);
        }
        [Fact]
        public void ICanAddMultipleNodesToTheEnd()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);
            int[] testValues = new int[] { 4, 5, 6, 7, 8 };

            //Act
            ALink.Append(7);
            ALink.Append(8);
            int[] values = ALink.Print();

            //Assert
            Assert.Equal(testValues, values);
        }
        [Fact]
        public void ICanInsertBeforeANodeInTheMiddle()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);
            int[] testValues = new int[] { 4, 3, 5, 6};

            //Act
            ALink.InsertBefore(5, 3);
            int[] values = ALink.Print();

            //Assert
            Assert.Equal(testValues, values);
        }
        [Fact]
        public void ICanInsertBeforeANodeInFront()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            ALink.InsertBefore(4, 3);

            //Assert
            Assert.Equal(3, ALink.Head.Value);
        }
        [Fact]
        public void ICanInsertAfterANodeInTheMiddle()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);
            int[] testValues = new int[] { 4, 5, 3, 6 };

            //Act
            ALink.InsertAfter(5, 3);
            int[] values = ALink.Print();

            //Assert
            Assert.Equal(testValues, values);
        }
        [Fact]
        public void ICanInsertAfterANodeAtTheEnd()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);
            int[] testValues = new int[] { 4, 5, 6, 7 };

            //Act
            ALink.InsertAfter(6, 7);
            int[] values = ALink.Print();

            //Assert
            Assert.Equal(testValues, values);
        }
        [Fact]
        public void ICanGetAnExceptionFromChoosingAKthThatIsLongerThanTheLinkedList()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            Node node = ALink.KthFromTheEnd(7);

            //Assert
            Assert.Null(node);
        }
        [Fact]
        public void ICanGetAValueFromChoosingAKthThatIsTheSameLengthAsTheList()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            Node node = ALink.KthFromTheEnd(2);

            //Assert
            Assert.Equal(4, node.Value);
        }
        [Fact]
        public void ICanGetAnExceptionFromChoosingAKthThatIsNotAPositiveInterger()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            Node node = ALink.KthFromTheEnd(-3);

            //Assert
            Assert.Null(node);
        }
        [Fact]
        public void ICanGetAValueFromChoosingAKthThatIsFromAListThatIsOnlyOneNodeLong()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            

            //Act
            Node node = ALink.KthFromTheEnd(0);

            //Assert
            Assert.Equal(6, node.Value);
        }
        [Fact]
        public void ICanGetAKthFromTheEnd()
        {
            //Arrange
            LList ALink = new LList();
            ALink.Insert(6);
            ALink.Insert(5);
            ALink.Insert(4);

            //Act
            Node node = ALink.KthFromTheEnd(1);

            //Assert
            Assert.Equal(5, node.Value);
        }
    }
}

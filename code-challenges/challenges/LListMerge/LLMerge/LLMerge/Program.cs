using System;
using SinglyLinkedList.classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList ALink = null;

            LList BLink = new LList();
            BLink.Insert(9);
            BLink.Insert(7);
            BLink.Insert(5);

            LList list = MergeLists(ALink, BLink);

        }
        /// <summary>
        /// This method takes in two linked lists and merges them in a zipper fashion
        /// </summary>
        /// <param name="A">linked list a </param>
        /// <param name="B">linked list b </param>
        /// <returns>the merged linked list</returns>
        public static LList MergeLists(LList A, LList B)
        {
            try
            {
                Node ACurrent = A.Head;
                Node BCurrent = B.Head;
                Node C = BCurrent.Next;
                if (A.Head == null)
                {
                    return B;
                }
                if (B.Head == null)
                {
                    return A;
                }
                while (ACurrent != null && BCurrent != null)
                {
                    C = BCurrent.Next;
                    BCurrent.Next = ACurrent.Next;
                    ACurrent.Next = BCurrent;
                    BCurrent = C;
                    ACurrent = ACurrent.Next.Next;
                }
                if (ACurrent == null && BCurrent != null)
                {
                    while (BCurrent != null)
                    {
                        A.Append(BCurrent.Value);
                        BCurrent = BCurrent.Next;
                    }
                }
                return A;

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}

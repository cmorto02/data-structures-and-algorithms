using System;
using SinglyLinkedList.classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList ALink = new LList();
            ALink.Insert(8);
            ALink.Insert(6);
            ALink.Insert(4);

            LList BLink = new LList();
            BLink.Insert(9);
            BLink.Insert(7);
            BLink.Insert(5);

            LList list = MergeLists(ALink, BLink);
            list.PrintAllNodes();

        }
        public static LList MergeLists(LList A, LList B)
        {
            Node ACurrent = A.Head;
            Node BCurrent = B.Head;
            Node C = BCurrent.Next;
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
    }
}

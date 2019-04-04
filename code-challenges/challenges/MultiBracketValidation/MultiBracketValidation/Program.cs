using stacksAndQueues;
using stacksAndQueues.classes;
using System;
using System.Text;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "({[{()t}t]t}t])";
            string result = Convert.ToString(MultiBracketValidation(input));
            Console.WriteLine(result);
        }
        public static bool MultiBracketValidation(string input)
        {
            Stack<char> main = new Stack<char>();
            char[] charInputArray = input.ToCharArray();
            for (int i = 0; i < charInputArray.Length; i++)
            {
                if (charInputArray[i] == '(' || charInputArray[i] == '{' || charInputArray[i] == '[')
                {
                    main.Push(charInputArray[i]);
                }
                if (charInputArray[i] == ')' || charInputArray[i] == '}' || charInputArray[i] == ']')
                {
                    char result = main.Pop().Value;
                    if (charInputArray[i] == ')' && result != '(' || charInputArray[i] == '}' && result != '{' || charInputArray[i] == ']' && result != '[')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

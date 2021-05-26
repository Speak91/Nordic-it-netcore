using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "()";
            var s2 = "[]()";
            var s3 = "[[]()]";
            var s4 = "([([])])()[]";
            var s5 = "(";
            var s6 = "[][)";
            var s7 = "[(])";
            var s8 = "(()[]]";
            CheckingBrackets(s1);
            CheckingBrackets(s2);
            CheckingBrackets(s3);
            CheckingBrackets(s4);
            CheckingBrackets(s5);
            CheckingBrackets(s6);
            CheckingBrackets(s7);
            CheckingBrackets(s8);
        }

        static void CheckingBrackets (string brackets)
        {
            char[] splittingIntoSymbols = brackets.ToCharArray();
            bool resultOfChecking = true;

            Dictionary<char, char> typesOfBrackets = new Dictionary<char, char>();
            typesOfBrackets.Add(')', '(');
            typesOfBrackets.Add(']', '[');

            Stack<char> stackOfBrackets = new Stack<char>();
            foreach (char bracket in splittingIntoSymbols)
            {
                if (typesOfBrackets.ContainsValue(bracket))
                {
                    stackOfBrackets.Push(bracket);
                }
                else if (typesOfBrackets.ContainsKey(bracket))
                {
                    if (stackOfBrackets.Count > 0 && stackOfBrackets.Peek() == typesOfBrackets[bracket])
                    {
                        stackOfBrackets.Pop();
                    }
                    else
                    {
                        resultOfChecking = false;
                    }
                      
                }
            }
            if (stackOfBrackets.Count > 0)
            {
                resultOfChecking = false;
            }
            Console.WriteLine(resultOfChecking);
        }

    }
}

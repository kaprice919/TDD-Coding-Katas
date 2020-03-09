using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    public class Balancer
    {
        private static Dictionary<char,char> characterMap = new Dictionary<char, char>(){
            {')','('},
            {'}','{'},
            {']','['}
        };
        
        public static bool isBalanced(string expression)
        {
            Stack<char> processedChars = new Stack<char>();

            foreach(char c in expression)
            {
                if(characterMap.Values.ToList().Contains(c))
                    processedChars.Push(c);
                if(characterMap.Keys.ToList().Contains(c))
                    if( processedChars.Peek() == characterMap.GetValueOrDefault(c))
                        processedChars.Pop();
            }
            return (processedChars.Count == 0);
        }
    }
}
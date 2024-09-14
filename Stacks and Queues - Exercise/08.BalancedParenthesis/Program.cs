namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else 
                if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    char lastOpenBracket = stack.Pop();
                    if ((ch == ')' && lastOpenBracket != '(') ||
                        (ch == '}' && lastOpenBracket != '{') ||
                        (ch == ']' && lastOpenBracket != '['))
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            if (stack.Count > 0)
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
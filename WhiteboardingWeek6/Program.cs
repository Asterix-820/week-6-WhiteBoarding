// See https://.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Mysolution
{
    public class program
    {
        public static void Main(string[] args)
        {
            Stack<int> N = new Stack<int>();
            N.Push(1);
            N.Push(2);
            N.Push(4);
            N.Push(3);
            N.Push(3);
            N.Push(5);  

            Console.WriteLine(StackOp(N,7));
        }

        public static int StackOp(Stack<int> stack, int k)
        {
            int count = 0;

            while (count < k - 1 && stack.Count> 0) 
            {
                stack.Pop();
                count++;
            }

            if (stack.Count == 0) 
            {
                return -1;
            }
            return stack.Peek();
        }
    }
}
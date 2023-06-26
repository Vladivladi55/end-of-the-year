internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            foreach (int n in num) 
            {
                stack.Push(n - 48);
            }

            int sum = stack.Sum();
            for (int i = stack.Count; i > 1; i--)
            {
                Console.Write($"{stack.Pop()} + ");
            }
            Console.Write($"{stack.Pop()} = {sum}");
        }
    }

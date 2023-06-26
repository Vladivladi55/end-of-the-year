 internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            int searchNum = int.Parse(Console.ReadLine());

            for (int i = stack.Count; i > 0; i--)
            {
                if (stack.Pop() == searchNum)
                {
                    
                   break;
                }
            }
            if (stack.Count >= 0)
            {
                Console.WriteLine($"{searchNum} exists in the List");
            }
            else
            {
                Console.WriteLine($"{searchNum} not exists in the List");
            }
        }
    }

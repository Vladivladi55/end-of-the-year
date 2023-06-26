internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            foreach (int i in Stack)
            {
                if (i >= 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
            foreach (int i in Stack)
            {
                if (i < 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

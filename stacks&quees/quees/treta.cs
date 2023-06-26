internal class Program
    {
        static void Main(string[] args)
        {
            int topBorder = int.Parse(Console.ReadLine());
            int bottomBorder = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Queue<int> Queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                Queue.Enqueue(int.Parse(Console.ReadLine()));
            }
            Queue.TrimExcess();

            Console.WriteLine("---------------------------");
            foreach (int i in Queue)
            {
                if (i > bottomBorder && i < topBorder)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

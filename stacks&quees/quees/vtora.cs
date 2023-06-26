internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> Queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                Queue.Enqueue(int.Parse(Console.ReadLine()));
            }

            double average = Queue.Average();
            Console.WriteLine("---------------------------");
            foreach (int i in Queue)
            {
                if (i > average)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

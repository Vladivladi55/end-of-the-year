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
            int searchNum = int.Parse(Console.ReadLine());

            for (int i = Queue.Count; i > 0; i--)
            {
                if (Queue.Dequeue() == searchNum)
                {
                    break;
                }
            }
            if (Queue.Count >= 0)
            {
                Console.WriteLine($"{searchNum} exists in the List");
            }
            else
            {
                Console.WriteLine($"{searchNum} not exists in the List");
            }
        }
    }

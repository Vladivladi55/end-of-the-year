 internal class Program
    {
        static void Main(string[] args)
        {
            List<int> St = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> Stack = new Stack<int>(St);
            Console.WriteLine(string.Join(" ", Stack));
        }
   }

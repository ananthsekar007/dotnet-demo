
namespace GenericNameSpace
{
    internal class Message<T>
    {
        public Message(T message)
        {
            Console.WriteLine(message);
        }
    }

    internal class Generics
    {
        public static  void Main(string[] args)
        {
            //var exampleIntegerSet = new SortedSet<int>(){ 5, 8, 1, 3, 1, 3, 10 };
            //var exampleCharSet = new SortedSet<char>() { 'B', 'L', 'A', 'D' };

            //foreach(var example in exampleIntegerSet)
            //{
            //    Console.WriteLine($" IntegerSet - {example}");
            //}

            //foreach (var example in exampleCharSet)
            //{
            //    Console.WriteLine($"Char set - {example}");
            //}

            Stack<string> stack = new Stack<string>();

            stack.Push("Hello");
            stack.Push("World");

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }

}


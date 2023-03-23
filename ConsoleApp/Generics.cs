
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
        public void Main(string[] args)
        {
            Message<string> message = new Message<string>("Hi");

        }
    }

}


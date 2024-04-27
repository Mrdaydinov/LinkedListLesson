namespace LinkedListLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            Console.WriteLine(stack.Pop());

            stack.Peek();

            Console.WriteLine("\n");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}

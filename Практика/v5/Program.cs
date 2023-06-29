public class List
    {
        protected int[] array;
        protected int size;
        protected int capacity;

        public List()
        {
            capacity = 10;
            array = new int[capacity];
            size = 0;
        }

        public virtual void Push(int value)
        {
            if (size == capacity)
            {
                capacity *= 2;
                int[] newArray = new int[capacity];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[size++] = value;
        }

        public virtual int Pop()
        {
            if (size == 0)
            {
                throw new Exception("List is empty");
            }
            int value = array[--size];
            return value;
        }

        public virtual void Enqueue(int value)
        {
            Push(value);
        }

        public virtual int Dequeue()
        {
            if (size == 0)
            {
                throw new Exception("List is empty");
            }
            int value = array[0];
            for (int i = 1; i < size; i++)
            {
                array[i - 1] = array[i];
            }
            size--;
            return value;
        }
    }

    public class Stack : List
    {
        public override int Pop()
        {
            if (size == 0)
            {
                throw new Exception("Stack is empty");
            }
            int value = array[--size];
            return value;
        }
    }

    public class Queue : List
    {
        public override int Dequeue()
        {
            if (size == 0)
            {
                throw new Exception("Queue is empty");
            }
            int value = array[0];
            for (int i = 1; i < size; i++)
            {
                array[i - 1] = array[i];
            }
            size--;
            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine();

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.ReadKey();
        }
    }

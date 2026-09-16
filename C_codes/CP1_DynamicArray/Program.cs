namespace  CP1_DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new IntArrayList();
            list.TryInsert(1, 15);
            list.TryInsert(0, 16);
            Console.WriteLine($"Found:{list.Find(16)}");
            Console.WriteLine($"Count:{list.Count} + Capacity:{list.Capacity}");
            Console.WriteLine("---");
            list.PushBack(20);
            list.PushBack(30);
            Console.WriteLine($"Count:{list.Count} + Capacity:{list.Capacity}");
            Console.WriteLine("---");
            list.TryErase(0);  
            Console.WriteLine($"Found:{list.Find(16)}");
            Console.WriteLine($"Count:{list.Count} + Capacity:{list.Capacity}");
            Console.WriteLine("---");
        }
    }
}
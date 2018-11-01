using System;

// Паттерн проектирования - Singleton.

namespace Static
{
    class Program
    {
        static void Main()
        {
            // Конструктор "protected" - невозможно использовать - new Singleton() 
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());

            if (instance1.GetHashCode() == instance2.GetHashCode())
                Console.WriteLine("Ссылки указывают на один экземпляр объекта.");            
            
            // Delay.
            Console.ReadKey();
        }
    }
}

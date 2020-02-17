using System;

namespace Composite_Design_Pattern_Quête_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person eric = new Person("Eric");
            Person jean = new Person("Jean");
            Person charlie = new Person("Charlie");
            eric.descendants1.Add(jean);
            eric.descendants1.Add(charlie);
            Console.WriteLine(eric);

        }
    }
}

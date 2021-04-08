using System;

namespace ClassExample
{
    class Program
    {
        public static Person obj = new Person();
        public static Person obj1 = new Person();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Please enter name ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter age ");
            string age = Console.ReadLine();

            int newAge = Convert.ToInt32(age);

            obj.SetMember(name, newAge);

            obj.GetMember(out name, out newAge);
            Console.WriteLine("Name: " + name + " Age " + newAge);

            Console.WriteLine("Please enter name for Obj1 ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter age Obj1");
            age = Console.ReadLine();

            newAge = Convert.ToInt32(age);

            obj1.SetMember(name, newAge);
            obj1.GetMember(out name, out newAge);
            Console.WriteLine("Name: " + name + " Age " + newAge);
        }
    }
}

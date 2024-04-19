using System.Reflection.PortableExecutable;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("1234567890");
            BankAccount account2 = new BankAccount("9876543210", 1000);
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Person person = new Person("Nicola", 25);            
            Console.WriteLine(person);
            Person person2 = new Person("Vanesa", 32);
            Console.WriteLine(person2);
        }
    }
}

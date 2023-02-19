using System;
namespace Git
{
class Git
{
static void Main(string[] args)
{
<<<<<<< HEAD
System.Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello, {name}!");
=======
System.Console.WriteLine("Enter your first name: ");
string first_name = Console.ReadLine();
System.Console.WriteLine("Now enter your last name: ");
string last_name = Console.ReadLine();
System.Console.WriteLine($"Hello{first_name} {last_name}!");
>>>>>>> 374a53b58e5f7c46dc7681a0a3a1b0a50943d84e
}
}
}
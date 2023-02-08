Console.Write("Enter your name ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey, it is Masha!");
}
else
{
    Console.WriteLine("Hey, ");
    Console.WriteLine(username);
}
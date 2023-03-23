int i = 0;
Console.Write("add number: ");
if (int.TryParse(Console.ReadLine(), out i))
{
    Console.WriteLine(i * i);
}
else
{
    Console.WriteLine("Oops");
}

using System.Xml.Schema;

Console.WriteLine("Which package would you like?:");
Console.WriteLine("\tPackage A: For $9.95 per month, 10 audiobooks are provided. Additional books are $2.00 per book.");
Console.WriteLine("\tPackage B: For $13.95 per month, 20 audiobooks are provided. Additional books are $1.00 per book.");
Console.WriteLine("\tPackage C: For $19.95 per month, unlimited audiobook access is provided.");

string pack = Console.ReadLine();



if (pack == "A" || pack == "B" || pack == "C")
{
    if (pack == "A")
    {
        Console.WriteLine("You have selected package A. How many audiobooks would you like?");
        int audiobooks = Convert.ToInt32(Console.ReadLine());
        Convert.ToDouble(audiobooks);
        double totalA = 9.95 + (audiobooks * 2.00);
        Console.WriteLine($"Your total will be ${totalA}");

    }
    if (pack == "B")
    {
        Console.WriteLine("You have selected package B. How many audiobooks would you like?");
        int audiobooks = Convert.ToInt32(Console.ReadLine());
        Convert.ToDouble(audiobooks);
        double totalB = 13.95 + (audiobooks * 1.00);
        Console.WriteLine($"Your total will be ${totalB}");
    }
    if (pack == "C")
    {
        double totalC = 19.95;
        Console.WriteLine("You have selected Package C.");
        Console.WriteLine($"Your total will be ${totalC}");
    }

}
while (pack != "A" || pack != "B" || pack != "C")
{
    Console.WriteLine("A package was not selected.");
    Console.WriteLine("Try again!");
    Console.WriteLine("Which package would you like?:");
    Console.WriteLine("\tPackage A: For $9.95 per month, 10 audiobooks are provided. Additional books are $2.00 per book.");
    Console.WriteLine("\tPackage B: For $13.95 per month, 20 audiobooks are provided. Additional books are $1.00 per book.");
    Console.WriteLine("\tPackage C: For $19.95 per month, unlimited audiobook access is provided.");

     pack = Console.ReadLine();
}
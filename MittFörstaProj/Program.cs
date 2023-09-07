// See https://aka.ms/new-console-template for more information

int number = 6;

//check if the numder is bigger than 10
if (number > 10)
{ 
    Console.WriteLine("talet är stort");
}
else
{
    Console.WriteLine("Oj. Lågt tal");
}

//ask about users name and let user write their name
Console.WriteLine("hej! vad heter du?");
string name = Console.ReadLine();

Console.WriteLine($"hej {name}!" );

//write the numers from 0 to the int number 6 
for (int i = 0; i <= number; i++)
{
    Console.WriteLine(i);
}

Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Enter your name: ");
string username = Console.ReadLine();
Console.WriteLine("Enter your birthdate in MM/dd/yyyy");
string userbirth = Console.ReadLine();

DateTime dateInput;

if (!DateTime.TryParse(userbirth, out dateInput))
{
    Console.WriteLine("Please enter a valid date");
}
else
{
    DateTime current = DateTime.Now;
    TimeSpan difference = current - dateInput;
    Console.WriteLine($"You are {difference / 365} years old");
}

const string dirname = "C:\\Users\\HP\\Documents\\COM313_TEST1\\user_info.txt";

if (!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
}

const string filename = "user_info.txt";

using (StreamWriter sw = File.CreateText(filename))
{
    sw.WriteLine($"Username: {username}");
    sw.WriteLine($"User Birthday: {dateInput}");
}

string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);

Console.WriteLine("Enter a directory path: ");
string userdirec = Console.ReadLine();

Console.WriteLine("Just files:");
List<string> thefiles = new List<string>(Directory.EnumerateFiles(userdirec));
foreach (string dir in thefiles)
{
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("Enter a string");
string userstring = Console.ReadLine();

string stringg = userstring.ToTitleCase();

Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
Console.ReadLine();
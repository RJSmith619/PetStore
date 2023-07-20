using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while(userInput.ToLower() != "exit")
{
    if(int.Parse(userInput) == 1)
    {
        Console.WriteLine("Testing");
    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;


Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while(userInput.ToLower() != "exit")
{
    if(int.Parse(userInput) == 1)
    {
        CatFood food = new CatFood();

        Console.WriteLine("Please enter the weight in pounds: ");
        food.WeightPounds = int.Parse(Console.ReadLine());


    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

}

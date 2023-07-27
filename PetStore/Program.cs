using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

//Prompt user to enter a value
//Console.WriteLine("Press 1 to add cat food. Press 2 to add dog leash.");
Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

//Store user input into a string variable
string userInput = Console.ReadLine();


while(userInput.ToLower() != "exit")
{
    if(userInput == "1")
    {
        DogLeash leash = new DogLeash();

        Console.Write("Please enter the name: ");
        leash.Name = Console.ReadLine();

        Console.Write("Please enter the price: ");
        leash.Price = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter the quantity: ");
        leash.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Please enter the description: ");
        leash.Description = Console.ReadLine();

        Console.Write("Please enter the material type: ");
        leash.Material = Console.ReadLine();

        Console.Write("Please enter the length in inches: ");
        leash.LengthInches = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Product Name: {0}\nPrice: {1}\nQuanitty: {2}\nDescription: {3}\nMaterial: {4}\nLength In Inches: {5}", 
            leash.Name, leash.Price, leash.Quantity, leash.Description, leash.Material, leash.LengthInches));

        //CatFood food = new CatFood();

        //Console.WriteLine("Please enter the weight in pounds: ");
        //food.WeightPounds = int.Parse(Console.ReadLine());

        //Console.WriteLine("Is this kitten food? Please type 'yes' or 'no'. ");
        //if (Console.ReadLine().ToLower() == "yes")
        //{
        //    food.KittenFood = true;
        //}
        //else
        //{
        //    food.KittenFood = false;
        //}

        //Console.WriteLine("Weight in pounds: {0}\nKitten Food: {1}", food.WeightPounds, food.KittenFood);
    }

    //TODO: Dog Leash IF statement//

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

}

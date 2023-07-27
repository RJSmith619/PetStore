using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

ProductLogic logic = new ProductLogic();

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

        logic.AddProduct(leash);
        Console.WriteLine("Your new product has been added!");
    }
    else if(userInput == "2") 
    {
        Console.WriteLine("Please enter which dog leash you want to view.");
        userInput = Console.ReadLine();

        DogLeash leash = logic.GetDogLeashByName(userInput);

        Console.WriteLine(String.Format("Product Name: {0}\nPrice: {1}\nQuanitty: {2}\nDescription: {3}\nMaterial: {4}\nLength In Inches: {5}",
            leash.Name, leash.Price, leash.Quantity, leash.Description, leash.Material, leash.LengthInches));
    }


    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to view a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();

}

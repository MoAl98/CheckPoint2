// See https://aka.ms/new-console-template for more information
using CheckPoint2;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

Console.WriteLine("Hello User!");

//Create an object 
List<Produkten> lista = new List<Produkten>();
//List<methoder> lista1 = new List<methoder>();

while (true)
{
    
   while (true)
   {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enter a new product. To stop enter ´q´ ");
        Console.ResetColor();

        Console.Write("Enter a catagory: ");
       string  category = Console.ReadLine();
        if (category.ToLower().Trim() == "q")//check if user want to quit 
        {
            break;
        }
        
        else if (string.IsNullOrEmpty(category))//Check if there is no value
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Du får inte ange ett tomt värde");
            Console.ResetColor();

        }
        else
        {
            Console.Write("Enter a product name: ");
            string productName = Console.ReadLine();
            
            Console.Write("Enter a price: ");
            int Price = Convert.ToInt32(Console.ReadLine());
           // int Price1 = Price;
            lista.Add(new Produkten(category, productName, Price));//add user input to the list 
            //lista1.Add(new methoder(Price1));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product was succesfully added ");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
        

   }
 
   Console.WriteLine("----------------------------------------------------------------------------------------------");
   Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine("category".PadRight(10) + "productName".PadRight(15) + "Price".PadRight(10));
   Console.ResetColor();
   List<Produkten> sortedPrice = lista.OrderBy(Produkten => Produkten.Price).ToList(); //sort the list

          


    foreach (Produkten produkten in sortedPrice)
    {
        Console.WriteLine(produkten.Print());//call the method print from Produkten class
       
    }

    //var totaly =methoder.summan;
   
  
   var total1 = lista.Sum(element => element.Price);//sum of the prices 
   Console.WriteLine("Total price:          " + total1);

   Console.ForegroundColor = ConsoleColor.Blue;
   Console.WriteLine("If you want to start the program again press: p --------Otherwise press anything to end the program");
   Console.ResetColor();

    string igen = Console.ReadLine();

    if (igen.ToLower().Trim() != "p")//check if the user want to put more values 
    {
        break;
    }
    


}



   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("End of the program! Thanks for using it!");
   Console.ResetColor();











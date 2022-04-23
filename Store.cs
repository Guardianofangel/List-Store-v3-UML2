using System;
using System.Collections.Generic;
using System.Text;

namespace List_Store_v3
{
    public class Store
    {
        public void Start()
        {
            MenuCatalog menu = new MenuCatalog();

            while (true)
            {
                try
                {
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.WriteLine("Welcome to Big Mamma Pizza");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.WriteLine("0 - Quit : ");
                    Console.WriteLine("1 - Overview : ");
                    Console.WriteLine("2 - Create : ");
                    Console.WriteLine("3 - Delete : ");
                    Console.WriteLine("4 - Update : ");
                    Console.WriteLine("5 - Search : ");
                    Console.Write("Choose : ");

                    int option = Int32.Parse(Console.ReadLine());
                    if (option == 0)
                    {
                        break;
                    }
                    //quit            


                    else if (option == 1)
                    // shows how many pizza there are currently
                    {
                        menu.PrintPizza();
                    }
                    // Create option 
                    else if (option == 2)
                    {
                        Console.Write("Type Pizza Name : ");
                        string name = Console.ReadLine();

                        Console.Write("Type Price : ");
                        int price = Int32.Parse(Console.ReadLine());

                        Console.Write("Type ID : ");
                        int iD = Int32.Parse(Console.ReadLine());

                        menu.CreatePizza(name, price, iD);
                    }
                    else if (option == 3)
                    {
                        // a method that deletes Pizzas   
                        Console.Write("To Remove, type Name : ");
                        string name = Console.ReadLine();


                        menu.RemovePizza(name);

                    }
                    else if (option == 4)
                    {
                        Console.Write("Type The ID number to update");
                        int iD = Int32.Parse(Console.ReadLine());

                        Console.Write(" Type Name : ");
                        string name = Console.ReadLine();

                        Console.Write(" Type Price : ");
                        int price = Int32.Parse(Console.ReadLine());

                        menu.UpdatePizza(name, price, iD);
                    }
                    else if (option == 5)
                    {
                        Console.Write("Type the name to search : ");
                        string name = Console.ReadLine();

                        menu.SearchPizza(name);
                    }
                    else
                    {
                        Console.WriteLine("Error, please choose a valid number");
                    }

                }
                catch { Console.WriteLine("Error please choose a valid number"); }
             }
         }


     }

}
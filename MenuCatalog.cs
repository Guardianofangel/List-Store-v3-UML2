using System;
using System.Collections.Generic;
using System.Text;

namespace List_Store_v3
{
    public class MenuCatalog
    {
        // oprettelse af List
        List<Pizza> pizzas = new List<Pizza>();

        public MenuCatalog()
        {
            Pizza p1 = new Pizza("Falaffel", 50, 1);
            Pizza p2 = new Pizza("Shawarma", 65, 2);
            pizzas.Add(p1);
            pizzas.Add(p2);
        }

        //Min metode til at oprette Pizzaer 
        public void CreatePizza(string name, int price, int iD)
        {
            Pizza p = new Pizza(name, price, iD);
            pizzas.Add(p);
        }
        //metode til at fjerne pizzaer
        public void RemovePizza(string name)
        {

            foreach (var pizzaB in pizzas)
            {

                if (name.Equals(pizzaB.GetName()))
                {
                    pizzas.Remove(pizzaB);
                    Console.WriteLine($" Pizza { pizzaB} is now deleted");
                    break;

                }
            }
        }
        //kalder til Create metode
        public void PrintPizza()
        {
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza);

            }

        }
        public void UpdatePizza(string name, int price, int iD)
        {
            // på metoden anvender vi ID til at finde pizzan, så vi kan ændre navn og pris
            foreach (var pizza in pizzas)
            {
                if (iD == pizza.GetiD())
                {
                    pizza.SetName(name);
                    pizza.SetPrice(price);
                    Console.WriteLine("Pizza has been updated !");
                    break;
                }

            }
        }

        // på metoden anvender vi pizza listen som indeholder noget tilfælles, og derefter printer den hvis den ind
        public void SearchPizza(string name)
        {
            foreach (var pizza in pizzas)
            {
                if (pizza.GetName().Contains(name)) 
                {
                    Console.WriteLine($"{pizza}");
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace List_Store_v3
{
   public class Pizza
    {
        // globale variabler
        string name;
        int price;
        int iD;
    
        // Constructor
        public Pizza(string name, int price, int iD)
        {
            this.name = name;
            this.price = price;
            this.iD = iD;
        }
        //properties
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetID(int iD)
        {
            this.iD = iD;
        }
        public int GetiD()
        {
            return iD;
        }
        // override tostring metode
        public override string ToString()
        {
            return $" Name : {name}  Price : {price}  ID Number : {iD}";
        }


    }
}

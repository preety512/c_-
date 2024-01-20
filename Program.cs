using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Cbrt(8);
            Math.Min(20.5,50.7);
            Console.ReadLine();
        }
      
    }
    //complex coding -> modularity
     public class Calculator
    {
      public  int size;//instance member
       public string color;//instance member
       public static string name = "Calculator";
       public float price;
      public  void Description()
        {
            Console.WriteLine("Name of products :" +name +" and color of products is :"+color);
        }
      public  void SellingPrice()
        {
            // products price+18% GST
            float SellingPrice;//local variable
            SellingPrice = price + ((price * 18) / 100);
            Console.WriteLine("Selling price of product is :" + SellingPrice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvetoryManagementSystem
{
    class Program
    {
       
        static void Main(string[] args)
        {


            List<ProductStore> Products = new List<ProductStore>();
            
            var p1= new ProductStore ( "lettuce", 10.5, 50, "Leafy green");
            Products.Add(p1);
            var p2=new ProductStore ( "cabbage", 20, 100, "Curciferous" );
            Products.Add(p2);
            var p3=new ProductStore ( "pumpkin", 30, 30, "Marrow" );
            Products.Add(p3);
            var p4= new ProductStore ( "cauliflower", 10, 25, "Curciferous" );
            Products.Add(p4);
            var p5=new ProductStore ( "zucchini", 20.5, 50, "Marrow" );
            Products.Add(p5);
            var p6=new ProductStore ( "yam", 30, 50, "Root" );
            Products.Add(p6);
            var p7= new ProductStore ( "spinach", 10, 100, "Leafy green" );
            Products.Add(p7);
            var p8=new ProductStore ( "broccoli", 20.2, 75, "Curciferous" );
            Products.Add(p8);
            var p9=new ProductStore ( "garlic", 30, 20, "Leafy green" );
            Products.Add(p9);
            var p10= new ProductStore ("silverbeet", 10, 50, "Marrow" );
            Products.Add(p10);

            Console.WriteLine($"Total No Of Product In The List: {Products.Count}");

            var p11 = new ProductStore("Potato", 10, 50, "Root");
            Products.Add(p11);

            Console.WriteLine("Product List");
            foreach (var p in Products)
            {
                Console.WriteLine(p.Name  + ":" + p.Price + ":" + p.Quantity + ":" + p.type);
            }
            
            Console.WriteLine($"Total No Of Product After Addition Of New Product: {Products.Count}");
            foreach (var p in Products)
            {
                if(p.type=="Leafy green")
                {
                    Console.WriteLine(p.Name + ":" + p.Price + ":" + p.Quantity + ":" + p.type);
                }
            }
            Products.Remove(p9);
            Console.WriteLine($"Total No Of Product After Deltion Of Garlic: {Products.Count}");
            foreach (var p in Products)
            {
                if(p.Name=="cabbage")
                {
                    int totalQuantity = p.Quantity + 50;
                    Console.WriteLine("Final Quantity Of Cabbage:"+totalQuantity);
                }
            }

            foreach (var p in Products)
            {
                if (p.Name=="lettuce")
                {
                    Console.WriteLine("Price of lettuce"+ p.Price);

                    
                    
                }
                
                if (p.Name == "zucchini")
                {
                    Console.WriteLine("Price of zucchini" + p.Price);
                   

                }
                if (p.Name == "broccoli")
                {
                    Console.WriteLine("Price of broccoli" + p.Price);
                   

                }
            }

            Console.WriteLine("User Have To Pay:" + ((1*p1.Price)+(2*p5.Price)+(1*p8.Price)));


            Console.ReadKey();



        }

    }
    
}

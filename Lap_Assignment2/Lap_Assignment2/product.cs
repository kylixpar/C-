using System;
using System.Collections.Generic;
namespace Lap_Ass2
{
    class Product
    {
        string name;
        int id;
        float price;
        int qty;
        string image;
        string desc;
        List<string> gallery = new List<string>();


        public Product()
        {

        }

        public Product(int id, string name, float price, int qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            for (int i = 0; i < gallery.Count && i < 10; i++)
            {
                gallery.Add(gallẻy[i]);
            }

        }
        public void getInfo()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Qty: " + qty);
            Console.WriteLine("Image: " + image);
            Console.WriteLine("Desc: " + desc);
        }
        public void Qty()
        {
            if (this.qty > 0)
            {
                Console.WriteLine("In Stock: " + qty);
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
        }
        public void AddGallery(string img)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(img);
            }
            else
            {
                Console.WriteLine("Gallery is full. ");
            }
        }
        public void RemoveGallery()
        {
            Console.WriteLine("Remove at? ");
            int i = Int16.Parse(Console.ReadLine());
            gallery.RemoveAt(i);
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> gallery = new List<string>();
            gallery.Add("item1");
            Product product = new Product(1, "house", (float)10, 10, "img1", "blue balloon", gallery);
            product.getInfo();
        }
    }
}
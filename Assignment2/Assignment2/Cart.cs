using System;
using System.Collections.Generic;
using Assignmen2;

namespace Assignment2
{

    class Cart
    {

        int id;
        string customer;
        float grandTotal;
        List<Product> productList;
        string city;
        string country;

        public Cart()
        {
        }
        public Cart(int id, string customer, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.city = city;
            productList = new List<Product>();
            this.grandTotal = 0;
            this.country = country;
        }
        public void AddToCart(Product p)
        {
            productList.Add(p);

        }
        public void RemoveFromCart(Product p)
        {
            productList.Remove(p);

        }
        public float GetGrandTotal()
        {
            foreach (Product p in productList)
            {
                grandTotal += p.GetPrice() * p.GetQty();
            }
            if (country != "Vietnam")
            {
                return grandTotal * 105 / 100;
            }
            else if (city == "hanoi" || city == "HCM")
            {
                return grandTotal * 101 / 100;
            }
            else
            {
                return grandTotal * 102 / 100;
            }
        }

    }

}
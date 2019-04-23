using System;
using Assignment2;
namespace Assignmen2
{
    public class main
    {
        static Cart cart;
        public static void Main(String[] args)
        {
            cart = new Cart();
            showMenu();

        }
        public static void showMenu()
        {
            Console.WriteLine("1. Add to cart");
            Console.WriteLine("2. Remove from cart");
            Console.WriteLine("3. Calculate grand total");
            char c = Convert.ToChar(Console.ReadKey());
            Product p = new Product();
            switch (c)
            {
                case '1':
                    cart.AddToCart(p);
                    showMenu();
                    break;
                case '2':
                    cart.RemoveFromCart(p);
                    showMenu();
                    break;
                case '3':
                    Console.WriteLine(cart.GetGrandTotal());
                    break;
                default:
                    break;

            }
        }

    }
}
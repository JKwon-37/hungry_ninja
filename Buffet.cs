using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryNinjaAssign
{
    class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Chu-Toro Nigiri", 50, false, false),
            new Food("Meatball & Sphaghetti", 1300, false, false),
            new Food("Spicy Ramen", 1100, true, false),
            new Food("Avocado Mango Smoothie", 500, false, true),
            new Food("Yangnyum Chicken", 800, true, true),
            new Food("Cheeseburger", 600, false, false),
            new Food("Chocolate Shake", 500, false, true)
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        // Console.WriteLine(Menu[rand.Next(Menu.Count)]);
        return Menu[rand.Next(Menu.Count)];
    }
}


}

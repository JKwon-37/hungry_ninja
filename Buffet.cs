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
            new Food("Example", 1000, false, false)
        };
    }
     
    public Food Serve()
    {
        
    }
}


}
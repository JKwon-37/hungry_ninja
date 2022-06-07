using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryNinjaAssign;

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;


        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                    return true;
                return false;
            }
        }
        public void Eat(Food item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                if (item.IsSpicy){
                    Console.WriteLine("Hot damn!");
                } 
                if (item.IsSweet){
                    Console.WriteLine("Sweet baby Jesus!");
                }
            } else {
                Console.WriteLine("I'm too full...");
            }
        }
    }




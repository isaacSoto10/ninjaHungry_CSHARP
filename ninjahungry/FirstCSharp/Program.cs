using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
        {
            Name = this.Name;
            Calories = this.Calories;
            IsSpicy = this.IsSpicy;
            IsSweet = this.IsSweet;
        }

    }
    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("pizza", 1000, false, false),
                new Food("Pasta", 1000, false, false),
                new Food("Nuggets", 1000, false, false)
            };
        }
        public Food RandomFood()
        {
            var rnd = new Random();
            int index = rnd.Next(Menu.Count);
            return Menu[index];           
        }

    }
    class ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        public string Calorie()
        {

            calorieIntake = 0;
            FoodHistory = new List<Food>();
            return "";
        }
        public bool IsFull
        {
            get
            {
                if(calorieIntake > 1200){
                    return true;
                }
                return false;
            
            }
        }
        // add a constructor
        
        // add a public "getter" property called "IsFull"
        
        // build out the Eat method
        public void Eat(Food item)
        {
            while(IsFull == false)
            {
                calorieIntake++;
                Buffet buffet = new Buffet();
                buffet.RandomFood();
                Console.WriteLine($"{item.Name} is it spicy? {item.IsSpicy}");
            }
            Console.WriteLine("Ninja is FUll");
        }
    }

}



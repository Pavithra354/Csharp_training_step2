using System;

namespace CoffeeBrewingExample
{
    static class CoffeeTools
    {
        public static void GetCoffeeUtensils()
        {
            Console.WriteLine("☕ Getting coffee mug, spoon, and kettle ready.");
        }

        public static void BoilWater()
        {
            Console.WriteLine("💧 Boiling water...");
        }
    }

    class CoffeeRecipe
    {
        public const string DrinkName = "Hot Coffee";
        private readonly string pavithraName;

        private string coffeeType;
        public bool AddSugar { get; set; }
        public int SugarLevel { get; set; }

        public CoffeeRecipe(string pavithra)
        {
            pavithraName = pavithra;
            coffeeType = "Instant Coffee";
            AddSugar = false;
        }

        public string GetPavithraName()
        {
            return pavithraName;
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("🫘 Adding coffee powder to the cup...");
            CoffeeTools.BoilWater();
        }

        public void SetSugarLevel(int level)
        {
            SugarLevel = level;
            AddSugar = level > 0;
            Console.WriteLine($"🍬 Sugar level set to: {level}");
        }

        public bool CheckIngredientsAvailability(bool hasMilk)
        {
            if (!hasMilk)
            {
                Console.WriteLine("❌ No milk available. Cannot make coffee.");
                return false;
            }

            Console.WriteLine("✅ All ingredients available to brew coffee!");
            return true;
        }

        public void StartBrewing(string type)
        {
            Console.WriteLine("🔥 Brewing coffee...");

            switch (type.ToLower())
            {
                case "black":
                    Console.WriteLine("Brewing Black Coffee.");
                    coffeeType = "Black Coffee";
                    break;
                case "latte":
                    Console.WriteLine("Brewing Latte.");
                    coffeeType = "Latte";
                    break;
                case "cappuccino":
                    Console.WriteLine("Brewing Cappuccino.");
                    coffeeType = "Cappuccino";
                    break;
                default:
                    Console.WriteLine("Unknown coffee type. Brewing regular Hot Coffee.");
                    coffeeType = "Hot Coffee";
                    break;
            }

            if (AddSugar)
            {
                Console.WriteLine("Adding sugar based on your preference.");
            }
            else
            {
                Console.WriteLine("No sugar added as per your preference.");
            }
        }

        public void ServeCoffee(int cups)
        {
            for (int i = 1; i <= cups; i++)
            {
                Console.WriteLine($"🍵 Serving coffee cup #{i}.");
            }

            int remaining = cups;
            while (remaining > 0)
            {
                Console.WriteLine($"Remaining cups to serve: {remaining}");
                remaining--;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("👩‍🍳 Welcome to Pavithra's Coffee Brewing Debugger App!");

            Console.Write("Enter your name (Pavithra’s name): ");
            string pavithraName = Console.ReadLine();

            CoffeeRecipe coffee = new CoffeeRecipe(pavithraName);

            CoffeeTools.GetCoffeeUtensils();
            coffee.PrepareIngredients();

            Console.Write("Enter sugar level (0-5): ");
            int sugarLevel = int.Parse(Console.ReadLine());
            coffee.SetSugarLevel(sugarLevel);

            Console.Write("Do you have milk? (yes/no): ");
            string milkInput = Console.ReadLine();
            bool hasMilk = milkInput.ToLower() == "yes";

            bool canBrew = coffee.CheckIngredientsAvailability(hasMilk);

            if (canBrew)
            {
                Console.WriteLine("Select Coffee Type: Black / Latte / Cappuccino");
                Console.Write("Enter your choice: ");
                string coffeeType = Console.ReadLine();

                coffee.StartBrewing(coffeeType);

                Console.Write("Enter number of cups to serve: ");
                int cups = int.Parse(Console.ReadLine());

                coffee.ServeCoffee(cups);

                Console.WriteLine($"👩‍🍳 Coffee is prepared by: {coffee.GetPavithraName()}");
                Console.WriteLine("✅ Enjoy your coffee! ☕");
            }
            else
            {
                Console.WriteLine($"❌ Coffee could not be brewed by Pavithra ({coffee.GetPavithraName()}) due to missing ingredients.");
                Console.WriteLine("🙏 Please come back later.");
            }
        }
    }
}
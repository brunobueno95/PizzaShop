namespace PizzaShop
{
    internal class Pizza
    {
        public static List<Psize> AllSizes = new List<Psize>() { new Small(), new Medium(), new Big() };
        public static List<Pizza> AllPizzasWeOffer { get; set; }
        public string Name { get; set; }

        public Psize Size { get; set; }

        public static List<string> BottomL { get; set; }

        public List<string> ThisPizzatoppings { get; set; }
        public List<string> Alltoppings { get; set; }

        public string BottomChoice { get; set; }

        public string Toppings1 { get; set; }

        public string Toppings2 { get; set; }

        public string Toppings3 { get; set; }

        public string Toppings4 { get; set; }

        public string AllThisToppings { get; set; }

        public string Toppings5 { get; set; }
        public Pizza(string _name, Psize _size, string _bottomChoice, string _toppings1)
        {
            Name = _name;
            Size = _size;
            BottomChoice = _bottomChoice;
            Toppings1 = _toppings1;
            ThisPizzatoppings = new List<string>()
            {
                Toppings1
            };
        }

        public Pizza(string _name, Psize _size, string _bottomChoice, string _toppings1, string _toppings2, string _toppings3)
        {
            Name = _name;
            Size = _size;
            BottomChoice = _bottomChoice;
            Toppings1 = _toppings1;
            Toppings2 = _toppings2;
            Toppings3 = _toppings3;
            ThisPizzatoppings = new List<string>()
            {
                Toppings1,
                Toppings2,
                Toppings3
            };

        }

        public Pizza(string _name, Psize _size, string _bottomChoice, string _toppings1, string _toppings2, string _toppings3, string _toppings4, string _toppings5)
        {
            Name = _name;
            Size = _size;
            BottomChoice = _bottomChoice;
            Toppings1 = _toppings1;
            Toppings2 = _toppings2;
            Toppings3 = _toppings3;
            Toppings4 = _toppings4;
            Toppings5 = _toppings5;
            ThisPizzatoppings = new List<string>()
            {
                Toppings1,
                Toppings2,
                Toppings3,
                Toppings4,
                Toppings5,
            };
        }


        
        public Pizza()
        {
           
        }

        public void fillUpList()
        {
            Alltoppings = new List<string>();
            Alltoppings.Add("Peperoni");
            Alltoppings.Add("Pineaple");
            Alltoppings.Add("Tomato");
            Alltoppings.Add("Ham");
            Alltoppings.Add("Corn");
            Alltoppings.Add("Mushroom");
            Alltoppings.Add("Red Pepper");
            Alltoppings.Add("Blue Cheese");
            Alltoppings.Add("Onion");
            Alltoppings.Add("Kebab Meat");
            Alltoppings.Add("Garlic");
            Alltoppings.Add("Mozzarella");
            Alltoppings.Add("Bacon");
            Alltoppings.Add("Beef");

            BottomL = new List<string>();
            BottomL.Add("Italian");
            BottomL.Add("American");
        }

        public void Information()
        {
           
            foreach(var item in ThisPizzatoppings)
            {
                AllThisToppings += " - " + item;


            }

            Console.WriteLine($"{Name} has those toppings : {AllThisToppings}. The size is {Size.SizeName} and the bottom {BottomChoice} \n");
        }


        public static void CreatingPizzasWeOffer(Psize size, string bottom)
        {                               //name                     //toppin1
            Pizza Capricciosa = new Pizza("Pizza Capricciosa", size, bottom, "Mozzarella", "Ham", "Mushroom");
            Pizza ConPancetta = new Pizza("Pizza Con Pancetta", size, bottom, "Mozzarella", "Bacon", "Onion");
            Pizza DiManzo = new Pizza("Pizza di Manzo", size, bottom, "Mozzarella", "Beef", "Red Pepper");
            Pizza Margherita = new Pizza("Pizza Margherita", size, bottom, "Mozzarella");
            Pizza Pepperoni = new Pizza("Pizza Pepperoni", size, bottom, "Pepperoni", "Red Pepper", "Bacon");
            Pizza Hawaii = new Pizza("Hawaii", size, bottom, "Pineapple", "Ham", "Corn", "beef", "Garlic");
            Pizza Simple = new Pizza("Pizza Simple", size, bottom, "Mozzarella", "Tomato", "Ham");
            Pizza Dream = new Pizza("Pizza Dream", size, bottom, "Mozzarella", "Beef", "Red Pepper");
            Pizza Special = new Pizza("Pizza Special", size, bottom, "Mozzarella", "Tomato", "Kebab Meat", "Onion", "Bacon");
            Pizza Mix = new Pizza("Pizza Mix", size, bottom, "Mozzarella", "Tomato", "Pepperoni", "Onion", "Red Pepper");

            AllPizzasWeOffer = new List<Pizza>();
            AllPizzasWeOffer.Add(Capricciosa);
            AllPizzasWeOffer.Add(ConPancetta);
            AllPizzasWeOffer.Add(DiManzo);
            AllPizzasWeOffer.Add(Margherita);
            AllPizzasWeOffer.Add(Pepperoni);
            AllPizzasWeOffer.Add(Hawaii);
            AllPizzasWeOffer.Add(Simple);
            AllPizzasWeOffer.Add(Dream);
            AllPizzasWeOffer.Add(Special);
            AllPizzasWeOffer.Add(Mix);
        }

        public static void ShowAllPizzasWeOffer()
        {
            foreach(var item in AllPizzasWeOffer)
            {
                item.Information();
            }

        }
    }
}

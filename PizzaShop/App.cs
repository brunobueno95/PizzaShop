namespace PizzaShop
{
    internal class App
    {
        public App()
        {
            RunApp();
        }

        public void RunApp()
        {
            Pizza FillList = new Pizza();
            FillList.fillUpList();
            ValidateInput.ValidateGreeting(Greetings());

        }

        public string Greetings()
        {
            Console.WriteLine("Hey, welcome to our PizzaShop!");
            Console.WriteLine("Press 1 to check our Meny, or 2 to make your own pizza");
            var Input = Console.ReadLine();
            return Input;

        }

        public static void ChooseSize()
        {
            Console.WriteLine("Welcome to our Meny, first choose wich size do you want");
            for (int i = 0; i < Pizza.AllSizes.Count; i++)
            {
                Console.WriteLine(i+1 + " - " + Pizza.AllSizes[i].info());

            }


        }

        public static void ChooseBottom()
        {
            Console.WriteLine("choose wich bottom do you want");
            for (int i = 0; i < Pizza.BottomL.Count; i++)
            {
                Console.WriteLine(i+1 + " - " + Pizza.BottomL[i]);

            }

        }
    }
}

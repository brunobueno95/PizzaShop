using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    internal class ValidateInput
    {
       
        public static  void ValidateGreeting(string input)
        {
            if(input == "1")
            {
                App.ChooseSize();
                var ChooseSizeInput = Console.ReadLine();
                App.ChooseBottom();
                var thirdInput = Console.ReadLine();
                var BottomChoice = ValidateBottomInput(thirdInput);
                var sizeChoice = ValidateSizeInput(ChooseSizeInput);

                Pizza.CreatingPizzasWeOffer(sizeChoice, BottomChoice);

                Pizza.ShowAllPizzasWeOffer();




            }

            else if(input == "2")
            {
                
            }

        }

        public static Psize ValidateSizeInput(string input)
        {
            //try
            //{
                if (input == "1")
                {
                    Psize small = new Small();
                    return small;
                }
                if (input == "2")
                {
                    Psize medium = new Medium();
                    return medium;
                }
                if (input == "3")
                {
                    Psize big = new Big();
                    return big;
                }

            //}
            //catch
            //{
            else
            {
                Console.WriteLine("Invalid input!So we ll offer you size medium!");
                return new Medium();
            }
                

            //}
            

        }


        public static string ValidateBottomInput(string input)
        {
            if(input == "1")
            {
                return "Italian";
            }
            if (input == "2")
            {
                return "American";
            }
           else
            {
                return "Ivvalid";
            }
        }
       
    }
}

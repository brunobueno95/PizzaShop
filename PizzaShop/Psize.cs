namespace PizzaShop
{
    internal abstract class Psize
    {
        public int Slices { get; set; }

        public int Diameter { get; set; }

        public string SizeName { get; set; }

        public double Area()
        {
            var Area = Diameter * 3.14;
            return Area;
        }

        public string info()
        {
            return $"The {SizeName} has {Diameter} cm of diameter, it has {Area()} cm of Area and is divided in {Slices} slices";
        }


    }
}

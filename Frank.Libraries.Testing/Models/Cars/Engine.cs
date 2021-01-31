namespace Frank.Libraries.Testing.Models.Cars
{
    public class Engine
    {
        public Engine(string name, Fuel fuel, int horsePower)
        {
            Name = name;
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public string Name { get; set; }
        public Fuel Fuel { get; set; }
        public int HorsePower { get; set; }
    }
}

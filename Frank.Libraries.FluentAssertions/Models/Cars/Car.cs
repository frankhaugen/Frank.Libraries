namespace Frank.Libraries.Testing.Models.Cars
{
    public class Car
    {
        public Car(string name, Engine engine)
        {
            Name = name;
            Engine = engine;
        }

        public string Name { get; set; }
        public Engine Engine { get; set; }
    }
}
